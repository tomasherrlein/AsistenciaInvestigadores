using System.ServiceProcess;
using Microsoft.Extensions.DependencyInjection;

namespace WinFormsAsistenciaInvestigadores
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var services = new ServiceCollection();
            ConfigureServices(services);
            var serviceProvider = services.BuildServiceProvider();

            var mainForm = serviceProvider.GetRequiredService<Form1>();
            Application.Run(mainForm);
        }

        private static void ConfigureServices(ServiceCollection services)
        {
            services.AddTransient<Form1>();
        }
    }
}