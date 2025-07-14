using ApplicationBussines;
using ApplicationBussines.QueryObjects;
using ApplicationBussines.UseCasesInvestigador;
using Entities;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAsistenciaInvestigadores
{
    public partial class FormInvestigadores : Form
    {

        private IServiceProvider _serviceProvider;
        private InvestigadorConDepartamentosQuery _query;
        private IInvestigadorRepository _repository;
        private SoftDeleteInvestigador _softDelete;
        private SoftRestoreInvestigador _softRestore;
        private bool _mostrarEliminados = false;

        public FormInvestigadores(IServiceProvider serviceProvider,
            InvestigadorConDepartamentosQuery query,
            IInvestigadorRepository repository,
            SoftDeleteInvestigador softDelete,
            SoftRestoreInvestigador softRestore)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _query = query;
            _repository = repository;
            _softDelete = softDelete;
            _softRestore = softRestore;
        }


        private async void FormMain_LoadAsync(object sender, EventArgs e)
        {
            await Reload();
        }

        private async Task Reload()
        {
            

            if(_mostrarEliminados)
            {
                var investigadoresEliminados = await _query.ExecuteAsyncEliminados();

                dataGridView1.DataSource = investigadoresEliminados;
                if (dataGridView1.Columns.Contains("Id"))
                {
                    dataGridView1.Columns["Id"].Visible = false;
                }

                if (!dataGridView1.Columns.Contains("RestoreButton"))
                {
                    AgregarColumnasRestaurar();
                }
            }
            else
            {
                var investigadoresActivos = await _query.ExecuteAsync();

                dataGridView1.DataSource = investigadoresActivos;
                if (dataGridView1.Columns.Contains("Id"))
                {
                    dataGridView1.Columns["Id"].Visible = false;
                }

                if (!dataGridView1.Columns.Contains("DeleteButton") || !dataGridView1.Columns.Contains("EditButton"))
                {
                    AgregarColumnasEliminar();
                }
            }
        }

        private async void btnFiltroMecanica_Click(object sender, EventArgs e)
        {
            var investigadores = await _query.ExecuteAsyncFiltered("Mecánica");
            dataGridView1.DataSource = investigadores;
        }

        private async void btnFiltroElectrica_Click(object sender, EventArgs e)
        {
            var investigadores = await _query.ExecuteAsyncFiltered("Eléctrica");
            dataGridView1.DataSource = investigadores;
        }

        private async void btnFiltroCivil_Click(object sender, EventArgs e)
        {
            var investigadores = await _query.ExecuteAsyncFiltered("Civil");
            dataGridView1.DataSource = investigadores;
        }

        private async void btnFiltroAutomotriz_Click(object sender, EventArgs e)
        {
            var investigadores = await _query.ExecuteAsyncFiltered("Automotriz");
            dataGridView1.DataSource = investigadores;
        }

        private async void btnFiltroLimpiar_Click(object sender, EventArgs e)
        {
            await Reload();
        }

        private async void btnAgregar_Click(object sender, EventArgs e)
        {
            var formAgregar = _serviceProvider.GetRequiredService<FormAgregarEditarInvestigador>();
            formAgregar.ShowDialog();
            await Reload();
        }

        private void AgregarColumnasEliminar()
        {
            if (dataGridView1.Columns.Contains("RestoreButton"))
            {
                dataGridView1.Columns.Remove("RestoreButton");
            }

            DataGridViewButtonColumn editButtonColumn = new DataGridViewButtonColumn();
            editButtonColumn.Name = "EditButton";
            editButtonColumn.HeaderText = "";
            editButtonColumn.Text = "Editar";
            editButtonColumn.UseColumnTextForButtonValue = true;
            editButtonColumn.DefaultCellStyle.BackColor = Color.Blue;
            editButtonColumn.DefaultCellStyle.ForeColor = Color.Blue;
            dataGridView1.Columns.Add(editButtonColumn);


            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
            deleteButtonColumn.Name = "DeleteButton";
            deleteButtonColumn.HeaderText = "";
            deleteButtonColumn.Text = "Eliminar";
            deleteButtonColumn.UseColumnTextForButtonValue = true;
            deleteButtonColumn.DefaultCellStyle.BackColor = Color.Red;
            deleteButtonColumn.DefaultCellStyle.ForeColor = Color.Red;
            dataGridView1.Columns.Add(deleteButtonColumn);
        }

        private void AgregarColumnasRestaurar()
        {
            if (dataGridView1.Columns.Contains("EditButton"))
            {
                dataGridView1.Columns.Remove("EditButton");
            }

            if (dataGridView1.Columns.Contains("DeleteButton"))
            {
                dataGridView1.Columns.Remove("DeleteButton");
            }
            

            DataGridViewButtonColumn restoreButtonColumn = new DataGridViewButtonColumn();
            restoreButtonColumn.Name = "RestoreButton";
            restoreButtonColumn.HeaderText = "";
            restoreButtonColumn.Text = "Restaurar";
            restoreButtonColumn.UseColumnTextForButtonValue = true;
            restoreButtonColumn.DefaultCellStyle.BackColor = Color.Green;
            restoreButtonColumn.DefaultCellStyle.ForeColor = Color.Green;
            dataGridView1.Columns.Add(restoreButtonColumn);
        }

        private async void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var investigadorId = (int)dataGridView1.Rows[e.RowIndex].Cells["Id"].Value;

            if (dataGridView1.Columns[e.ColumnIndex].Name == "EditButton")
            {
                var form = _serviceProvider.GetRequiredService<FormAgregarEditarInvestigador>();
                var investigador = await _repository.GetByIdAsync(investigadorId);
                var investigadorDto = new ApplicationBussines.DTOs.InvestigadorDTO
                {
                    Id = investigador.IdInvestigador,
                    Nombre = investigador.Nombre,
                    IdDepartamentos = investigador.Iddepartamentos.Select(d => d.IDDepartamento).ToList()
                };
                form.LoadData(investigadorDto);
                form.ShowDialog();
                await Reload();
            }

            if (dataGridView1.Columns[e.ColumnIndex].Name == "DeleteButton")
            {
                DialogResult ok = MessageBox.Show("¿Desea eliminar el investigador?", "Aviso", MessageBoxButtons.YesNo);
                if (ok == DialogResult.Yes)
                {
                    await _softDelete.ExecuteAsync(investigadorId);
                }
                await Reload();
            }

            if (dataGridView1.Columns[e.ColumnIndex].Name == "RestoreButton")
            {
                DialogResult ok = MessageBox.Show("¿Desea restaurar el investigador?", "Aviso", MessageBoxButtons.YesNo);
                if (ok == DialogResult.Yes)
                {
                    await _softRestore.ExecuteAsync(investigadorId);
                }

                await Reload();
            }

            
        }

        private async void btnMostrarEliminados_Click(object sender, EventArgs e)
        {
            _mostrarEliminados = !_mostrarEliminados;

            if (_mostrarEliminados)
            {
                btnMostrarEliminados.Text = "Mostrar activos";
            }
            else
            {
                btnMostrarEliminados.Text = "Mostrar eliminados";
            }

            await Reload();
        }
    }
}
