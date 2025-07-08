using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ApplicationBussines.DTOs;
using ApplicationBussines.QueryObjects;
using ApplicationBussines.UseCasesInvestigador;
using Entities;

namespace WinFormsAsistenciaInvestigadores
{
    public partial class FormAgregarEditarInvestigador : Form
    {
        private readonly AddInvestigador _addInvestigador;
        private readonly EditInvestigador _editInvestigador;
        private int? _investigadorId;

        public FormAgregarEditarInvestigador(AddInvestigador addInvestigador, EditInvestigador editInvestigador)
        {
            InitializeComponent();
            _addInvestigador = addInvestigador;
            _editInvestigador = editInvestigador;
        
        }

        public void LoadData(InvestigadorDTO investigadorDTO)
        {
            if (investigadorDTO != null)
            {
                _investigadorId = investigadorDTO.Id;
                txtbNombre.Text = investigadorDTO.Nombre;
                var idDepartamentos = investigadorDTO.IdDepartamentos;

                foreach (var id in idDepartamentos)
                {
                    if (id == 1) ckbMecanica.Checked = true;
                    if (id == 2) ckbElectrica.Checked = true;
                    if (id == 3) ckbCivil.Checked = true;
                    if (id == 4) ckbAutomotriz.Checked = true;
                }
                
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombreInvestigador = txtbNombre.Text.Trim();
            var departamentosIds = new List<int>();

            if (ckbMecanica.Checked) departamentosIds.Add(1);
            if (ckbElectrica.Checked) departamentosIds.Add(2);
            if (ckbCivil.Checked) departamentosIds.Add(3);
            if (ckbAutomotriz.Checked) departamentosIds.Add(4);

            if (string.IsNullOrWhiteSpace(nombreInvestigador))
            {
                MessageBox.Show("El nombre del investigador no puede estar vacío.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!departamentosIds.Any())
            {
                MessageBox.Show("Debe seleccionar al menos un departamento.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var investigadorDto = new InvestigadorDTO
            {
                Nombre = nombreInvestigador,
                IdDepartamentos = departamentosIds
            };

            try
            {
                if (_investigadorId.HasValue)
                {
                    await _editInvestigador.ExecuteAsync(_investigadorId.Value, investigadorDto);
                    MessageBox.Show("Se actualizó correctamente el investigador", "Aviso", MessageBoxButtons.OK);
                }
                else
                {
                    await _addInvestigador.ExecuteAsync(investigadorDto);
                    MessageBox.Show("Se agregó correctamente el investigador", "Aviso", MessageBoxButtons.OK);
                }
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
