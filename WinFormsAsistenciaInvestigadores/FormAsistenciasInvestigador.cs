using ApplicationBussines.QueryObjects;
using System.Threading.Tasks;

namespace WinFormsAsistenciaInvestigadores
{
    public partial class FormAsistenciasInvestigador : Form
    {
        private InvestigadorConDepartamentosQuery _query;
        public FormAsistenciasInvestigador(InvestigadorConDepartamentosQuery query)
        {
            InitializeComponent();
            _query = query;
        }

        private void CargarCalendario(int año, int mes)
        {
            tableLayoutPanel1.Controls.Clear();

            DateTime primerDiaMes = new DateTime(año, mes, 1);
            int diasEnMes = DateTime.DaysInMonth(año, mes);
            int diaSemana = ((int)primerDiaMes.DayOfWeek + 6) % 7; // lunes = 0

            int diaActual = 1;

            for (int fila = 0; fila < tableLayoutPanel1.RowCount; fila++)
            {
                for (int col = 0; col < tableLayoutPanel1.ColumnCount; col++)
                {
                    int index = fila * 7 + col;
                    Button btn = new Button();
                    btn.Dock = DockStyle.Fill;

                    if (index >= diaSemana && diaActual <= diasEnMes)
                    {
                        DateTime fecha = new DateTime(año, mes, diaActual);
                        btn.Text = diaActual.ToString();

                        btn.Tag = fecha;
                        btn.Click += BtnCalendario_Click;
                        diaActual++;
                    }
                    else
                    {
                        btn.Enabled = false;
                        btn.BackColor = SystemColors.Highlight;
                    }

                    tableLayoutPanel1.Controls.Add(btn, col, fila);
                }
            }
        }

        private void BtnCalendario_Click(object sender, EventArgs e)
        {
            //Abrir un nuevo form para agregar o editar asistencia.
        }

        private async void FormPrincipal_Load(object sender, EventArgs e)
        {
            LoadMonths();
            numericUpDownAnio.Value = DateTime.Now.Year;
            await Reload();
            dataGridView1.Columns["Id"].Visible = false;
        }

        private async Task Reload()
        {
            dataGridView1.DataSource = await _query.ExecuteAsync();
        }

        private void LoadMonths()
        {
            string[] meses = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };
            cboMeses.DataSource = meses;
            cboMeses.SelectedIndex = DateTime.Now.Month - 1;
        }

        private void btnCargarAsistencias_Click(object sender, EventArgs e)
        {
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

            if (dataGridView1.SelectedRows.Count > 0)
            {

                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                string nombre = selectedRow.Cells[1].Value.ToString();
                lblNombreInvestigador.Text = nombre;
            }

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
