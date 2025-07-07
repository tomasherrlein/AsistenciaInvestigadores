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
    public partial class FormPrincipal : Form
    {
        private IServiceProvider _serviceProvider;
        public FormPrincipal(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
        }

        private void btnFormInvestigadores_Click(object sender, EventArgs e)
        {
            var formInvestigadores = _serviceProvider.GetRequiredService<FormInvestigadores>();
            formInvestigadores.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var formAsistencias = _serviceProvider.GetRequiredService<FormAsistenciasInvestigador>();
            formAsistencias.ShowDialog();
        }
    }
}
