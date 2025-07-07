using ApplicationBussines;
using ApplicationBussines.QueryObjects;
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

        public FormInvestigadores(IServiceProvider serviceProvider, 
            InvestigadorConDepartamentosQuery query)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _query = query;
        }


        private async void FormMain_LoadAsync(object sender, EventArgs e)
        {
            await Reload();
            AgregarColumnas();
        }

        private async Task Reload()
        {
            var investigadores = await _query.ExecuteAsync();

            dataGridView1.DataSource = investigadores;
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var formAgregar = _serviceProvider.GetRequiredService<FormAgregarEditarInvestigador>();
            formAgregar.ShowDialog();
        }

        private void AgregarColumnas()
        {
            DataGridViewButtonColumn editButtonColumn = new DataGridViewButtonColumn();
            editButtonColumn.Name = "EditButton";
            editButtonColumn.HeaderText = "";
            editButtonColumn.Text = "Editar";
            editButtonColumn.UseColumnTextForButtonValue = true;
            editButtonColumn.DefaultCellStyle.BackColor = Color.Blue;
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
    }
}
