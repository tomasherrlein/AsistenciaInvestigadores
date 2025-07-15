using ApplicationBussines;
using ApplicationBussines.UseCasesAsistencia;
using ApplicationBussines.UseCasesInvestigador;
using Entities;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System;
using System.Windows.Forms;

namespace WinFormsAsistenciaInvestigadores
{
    public partial class FormAgregarEditarAsistencia : Form
    {
        private readonly AddAsistencia _addAsistencia;
        private readonly EditAsistencia _editAsistencia;
        private readonly DeleteAsistencia _deleteAsistencia;
        private Asistencia? _asistenciaActual;
        private bool _esEdicion = false;
        private int _investigadorId;
        private DateTime _fechaAsistencia;

        public FormAgregarEditarAsistencia(AddAsistencia addAsistencia, 
                                           EditAsistencia editAsistencia,
                                           DeleteAsistencia deleteAsistencia)
        {
            InitializeComponent();
            _addAsistencia = addAsistencia;
            _editAsistencia = editAsistencia;
            _deleteAsistencia = deleteAsistencia;
        }

        public void LoadDataAdd(int idInvestigador, DateTime fecha)
        {
            _investigadorId = idInvestigador;
            _fechaAsistencia = fecha;
            Text = $"Agregar Asistencia - {fecha:dd/MM/yyyy}";
            dtpHoraEntrada.Value = fecha.Date + new TimeSpan(9, 0, 0); // Default 9 AM
            dtpHoraSalida.Value = fecha.Date + new TimeSpan(17, 0, 0); // Default 5 PM
        }

        public void LoadDataEdit(Asistencia asistencia)
        {
            _asistenciaActual = asistencia;
            _esEdicion = true;

            Text = $"Editar Asistencia - {asistencia.Fecha:dd/MM/yyyy}";

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
                if (!_esEdicion)
                {
                    _asistenciaActual = new Asistencia
                    {
                        IDInvestigador = _investigadorId,
                        Fecha = DateOnly.FromDateTime(_fechaAsistencia),
                        HoraEntrada = horaEntrada,
                        HoraSalida = horaSalida
                    };
                    await _addAsistencia.ExecuteAsync(_asistenciaActual);
                }
                else
                {
                    _asistenciaActual.HoraEntrada = horaEntrada;
                    _asistenciaActual.HoraSalida = horaSalida;
                    await _editAsistencia.ExecuteAsync(_asistenciaActual);
                }

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al guardar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            if (!_esEdicion)
            {
                MessageBox.Show("No existe una asistencia para poder eliminar en esta fecha.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult ok = MessageBox.Show("¿Desea eliminar la asistencia?", "Aviso", MessageBoxButtons.YesNo);
            
            if (ok == DialogResult.Yes)
            {
                await _deleteAsistencia.ExecuteAsync(_asistenciaActual.IDAsistencia);
            }
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
