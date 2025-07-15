using ApplicationBussines;
using Entities;
using System;
using System.Windows.Forms;

namespace WinFormsAsistenciaInvestigadores
{
    public partial class FormAgregarEditarAsistencia : Form
    {
        private readonly IAsistenciaRepository _asistenciaRepository;
        private Asistencia asistenciaActual;
        private bool esEdicion = false;
        private int investigadorId;
        private DateTime fechaAsistencia;

        // Constructor para AGREGAR
        public FormAgregarEditarAsistencia(int idInvestigador, DateTime fecha, IAsistenciaRepository repo)
        {
            InitializeComponent();
            _asistenciaRepository = repo;
            investigadorId = idInvestigador;
            fechaAsistencia = fecha;
            this.Text = $"Agregar Asistencia - {fecha:dd/MM/yyyy}";
            dtpHoraEntrada.Value = fecha.Date + new TimeSpan(9, 0, 0); // Default 9 AM
            dtpHoraSalida.Value = fecha.Date + new TimeSpan(17, 0, 0); // Default 5 PM
        }

        // Constructor para EDITAR
        public FormAgregarEditarAsistencia(Asistencia asistencia, IAsistenciaRepository repo)
        {
            InitializeComponent();
            _asistenciaRepository = repo;
            asistenciaActual = asistencia;
            esEdicion = true;
            this.Text = $"Editar Asistencia - {asistencia.Fecha:dd/MM/yyyy}";

            // Cargar datos en los controles
            dtpHoraEntrada.Value = asistencia.Fecha.ToDateTime(asistencia.HoraEntrada);
            dtpHoraSalida.Value = asistencia.Fecha.ToDateTime(asistencia.HoraSalida);
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            TimeOnly horaEntrada = TimeOnly.FromDateTime(dtpHoraEntrada.Value);
            TimeOnly horaSalida = TimeOnly.FromDateTime(dtpHoraSalida.Value);

            if (horaSalida <= horaEntrada)
            {
                MessageBox.Show("La hora de salida debe ser posterior a la hora de entrada.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                if (!esEdicion)
                {
                    asistenciaActual = new Asistencia
                    {
                        IDInvestigador = investigadorId,
                        Fecha = DateOnly.FromDateTime(fechaAsistencia),
                        HoraEntrada = horaEntrada,
                        HoraSalida = horaSalida
                    };
                    await _asistenciaRepository.AddAsync(asistenciaActual);
                }
                else
                {
                    asistenciaActual.HoraEntrada = horaEntrada;
                    asistenciaActual.HoraSalida = horaSalida;
                    await _asistenciaRepository.EditAsync(asistenciaActual);
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al guardar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
