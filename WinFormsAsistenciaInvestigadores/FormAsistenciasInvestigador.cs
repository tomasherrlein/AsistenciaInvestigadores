using ApplicationBussines;
using ApplicationBussines.DTOs;
using ApplicationBussines.QueryObjects;
using Entities;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace WinFormsAsistenciaInvestigadores
{
    public partial class FormAsistenciasInvestigador : Form
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly InvestigadorConDepartamentosQuery _query;
        private readonly IAsistenciaRepository _asistenciaRepository;
        private InvestigadorDTO investigadorSeleccionado;

        public FormAsistenciasInvestigador(InvestigadorConDepartamentosQuery query, 
                            IAsistenciaRepository asistenciaRepository,
                            IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
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
            var asistenciasPorFecha = asistencias.ToDictionary(a => a.Fecha, a => a);

            foreach (Button btn in tableLayoutPanel1.Controls)
            {
                DateTime fechaDelBoton; // Variable para almacenar la fecha del día que representa el botón

                // Primero, intentar obtener la fecha si el Tag es un DateTime (estado inicial o reseteado)
                if (btn.Tag is DateTime tagDate)
                {
                    fechaDelBoton = tagDate;
                }
          
                else if (btn.Tag is Asistencia tagAsistencia)
                {
                    fechaDelBoton = tagAsistencia.Fecha.ToDateTime(TimeOnly.MinValue); // Obtener la fecha de la Asistencia
                }

                else
                {
                    // Si el Tag no es ni DateTime ni Asistencia, no es un botón de día que nos interese.
                    continue;
                }

                // Resetear el estado visual del botón
                btn.BackColor = SystemColors.Control;
                btn.Text = fechaDelBoton.Day.ToString(); // Siempre mostrar el número del día por defecto
                btn.FlatStyle = FlatStyle.Standard;
                btn.FlatAppearance.BorderColor = Color.Empty;
                btn.FlatAppearance.BorderSize = 0;

                // Buscar si hay una asistencia para esta fecha en los datos actualizados
                if (asistenciasPorFecha.TryGetValue(DateOnly.FromDateTime(fechaDelBoton), out Asistencia asistenciaDia))
                {
                    // Si se encontró una asistencia para este día, actualizar el botón con sus datos
                    btn.Tag = asistenciaDia; // Actualizar el Tag con la entidad Asistencia

                    try
                    {
                        TimeSpan tiempoEmpleado = asistenciaDia.GetTiempoEmpleado();
                        btn.Text =$"{fechaDelBoton.Day.ToString()}\nE: {asistenciaDia.HoraEntrada:HH:mm}\nS: {asistenciaDia.HoraSalida:HH:mm}\nTotal: {tiempoEmpleado:hh\\:mm}";
                        btn.BackColor = Color.LightGreen;
                        btn.FlatStyle = FlatStyle.Flat;
                        btn.FlatAppearance.BorderColor = Color.GreenYellow;
                        btn.FlatAppearance.BorderSize = 2;
                    }
                    catch (InvalidOperationException)
                    {
                        btn.Text = "Error en Horas";
                        btn.BackColor = Color.OrangeRed;
                        btn.FlatStyle = FlatStyle.Flat;
                        btn.FlatAppearance.BorderColor = Color.DarkRed;
                        btn.FlatAppearance.BorderSize = 2;
                    }
                }
                else
                {
                    // Si NO se encontró una asistencia para este día (ej. fue eliminada o nunca existió),
                    // el Tag vuelve a ser la fecha DateTime original.
                    // Esto es importante para que el botón se identifique correctamente como un día vacío en futuras cargas.
                    btn.Tag = fechaDelBoton;
                }
            }
        }


        private async void BtnCalendario_Click(object sender, EventArgs e)
        {
            Button btnDia = (Button)sender;
            var formAsistencia = _serviceProvider.GetRequiredService<FormAgregarEditarAsistencia>();

            if (btnDia.Tag is Asistencia)
            {
                Asistencia asistencia = (Asistencia)btnDia.Tag;
                formAsistencia.LoadDataEdit(asistencia);
            }
            else
            {
                DateTime fecha = (DateTime)btnDia.Tag;
                formAsistencia.LoadDataAdd(investigadorSeleccionado.Id, fecha);
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
