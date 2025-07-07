namespace WinFormsAsistenciaInvestigadores
{
    public partial class FormAsistenciasInvestigador : Form
    {
        public FormAsistenciasInvestigador()
        {
            InitializeComponent();
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

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            ///TODO: Cambiarlo por una fecha actual o seleccionada.
            CargarCalendario(2025, 7);
        }
    }
}
