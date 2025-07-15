using ApplicationBussines;
using ApplicationBussines.DTOs;
using ApplicationBussines.QueryObjects;
using Entities;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAsistenciaInvestigadores
{
    public partial class FormAsistenciasInvestigador : Form
    {
        private readonly InvestigadorConDepartamentosQuery _query;
        private readonly IAsistenciaRepository _asistenciaRepository;
        private InvestigadorDTO investigadorSeleccionado;

        public FormAsistenciasInvestigador(InvestigadorConDepartamentosQuery query, IAsistenciaRepository asistenciaRepository)
        {
            InitializeComponent();
            _query = query;
            _asistenciaRepository = asistenciaRepository;
        }

        private async void CargarCalendario(int anio, int mes)
        {
            tableLayoutPanel1.Controls.Clear();

            DateTime primerDiaMes = new DateTime(anio, mes, 1);
            int diasEnMes = DateTime.DaysInMonth(anio, mes);
            int diaSemana = ((int)primerDiaMes.DayOfWeek + 6) % 7; // lunes = 0

            int diaActual = 1;

            for (int fila = 0; fila < tableLayoutPanel1.RowCount; fila++)
            {
                for (int col = 0; col < tableLayoutPanel1.ColumnCount; col++)
                {
                    int index = fila * 7 + col;
                    Button btn = new Button();
                    btn.Dock = DockStyle.Fill;
                    btn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);


                    if (index >= diaSemana && diaActual <= diasEnMes)
                    {
                        DateTime fecha = new DateTime(anio, mes, diaActual);
                        btn.Text = diaActual.ToString();
                        btn.Tag = fecha;
                        btn.Click += BtnCalendario_Click;
                        diaActual++;
                    }
                    else
                    {
                        btn.Enabled = false;
                        btn.BackColor = SystemColors.ControlLight;
                    }

                    tableLayoutPanel1.Controls.Add(btn, col, fila);
                }
            }
            await CargarAsistenciasDelMes(anio, mes);
        }

        private async Task CargarAsistenciasDelMes(int anio, int mes)
        {
            if (investigadorSeleccionado == null) return;

            var asistencias = await _asistenciaRepository.GetAsistenciasDeInvestigadorPorMesAsync(investigadorSeleccionado.Id, anio, mes);

            foreach (Button btn in tableLayoutPanel1.Controls)
            {
                if (btn.Tag is DateTime)
                {
                    DateTime fechaBtn = (DateTime)btn.Tag;
                    var asistenciaDia = asistencias.FirstOrDefault(a => a.Fecha == DateOnly.FromDateTime(fechaBtn));

                    // Reset style before applying new one
                    btn.BackColor = SystemColors.Control;
                    btn.Text = fechaBtn.Day.ToString();

                    if (asistenciaDia != null)
                    {
                        btn.Tag = asistenciaDia;
                        try
                        {
                            TimeSpan tiempoEmpleado = asistenciaDia.GetTiempoEmpleado();
                            btn.Text = $"E: {asistenciaDia.HoraEntrada:HH:mm}\nS: {asistenciaDia.HoraSalida:HH:mm}\nTotal: {tiempoEmpleado:hh\\:mm}";
                            btn.BackColor = Color.GreenYellow;
                        }
                        catch (InvalidOperationException)
                        {
                            btn.Text = "Error en Horas";
                            btn.BackColor = Color.OrangeRed;
                        }
                    }
                }
            }
        }


        private async void BtnCalendario_Click(object sender, EventArgs e)
        {
            Button btnDia = (Button)sender;
            FormAgregarEditarAsistencia formAsistencia;

            if (btnDia.Tag is Asistencia)
            {
                Asistencia asistencia = (Asistencia)btnDia.Tag;
                formAsistencia = new FormAgregarEditarAsistencia(asistencia, _asistenciaRepository);
            }
            else
            {
                DateTime fecha = (DateTime)btnDia.Tag;
                formAsistencia = new FormAgregarEditarAsistencia(investigadorSeleccionado.Id, fecha, _asistenciaRepository);
            }

            var dialogResult = formAsistencia.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                int anio = ((int)numericUpDownAnio.Value);
                int mes = cboMeses.SelectedIndex + 1;
                await CargarAsistenciasDelMes(anio, mes);
            }
        }

        private async void FormPrincipal_Load(object sender, EventArgs e)
        {
            LoadMonths();
            numericUpDownAnio.Value = DateTime.Now.Year;
            await Reload();
            if (dataGridView1.Columns["Id"] != null)
                dataGridView1.Columns["Id"].Visible = false;
            if (dataGridView1.Columns["Eliminado"] != null)
                dataGridView1.Columns["Eliminado"].Visible = false;
        }

        private async Task Reload()
        {
            // Guardar selección actual
            int? selectedId = null;
            if (dataGridView1.SelectedRows.Count > 0)
            {
                selectedId = (int)dataGridView1.SelectedRows[0].Cells["Id"].Value;
            }

            dataGridView1.DataSource = await _query.ExecuteAsync();
            
            // Restaurar selección
            if (selectedId.HasValue)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if ((int)row.Cells["Id"].Value == selectedId.Value)
                    {
                        row.Selected = true;
                        break;
                    }
                }
            }
        }

        private void LoadMonths()
        {
            string[] meses = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };
            cboMeses.DataSource = meses;
            cboMeses.SelectedIndex = DateTime.Now.Month - 1;
        }

        private void btnCargarAsistencias_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView1.SelectedRows[0];
                investigadorSeleccionado = new InvestigadorDTO
                {
                    Id = (int)selectedRow.Cells["Id"].Value,
                    Nombre = selectedRow.Cells["Nombre"].Value.ToString()
                };
                lblNombreInvestigador.Text = investigadorSeleccionado.Nombre;
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un investigador de la lista.", "Investigador no seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (numericUpDownAnio.Value < 1900)
            {
                MessageBox.Show("Fuera del rango establecido (+1900)", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cboMeses.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un mes", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            int anio = ((int)numericUpDownAnio.Value);
            int mes = cboMeses.SelectedIndex + 1;
            CargarCalendario(anio, mes);

            lblNombreMes.Text = cboMeses.SelectedItem.ToString();
            lblAnioSeleccionado.Text = anio.ToString();
        }

        private async void btnFiltroMecanica_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = await _query.ExecuteAsyncFiltered("Mecánica");
        }

        private async void btnFiltroElectrica_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = await _query.ExecuteAsyncFiltered("Eléctrica");
        }

        private async void btnFiltroCivil_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = await _query.ExecuteAsyncFiltered("Civil");
        }

        private async void btnFiltroAutomotriz_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = await _query.ExecuteAsyncFiltered("Automotriz");
        }

        private async void btnFiltroLimpiar_Click(object sender, EventArgs e)
        {
            await Reload();
        }
    }
}
