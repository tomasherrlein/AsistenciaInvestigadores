using Repository;
using ApplicationBussines;
using Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Entities;
using Models;
using ApplicationBussines.Mappers;
using ApplicationBussines.QueryObjects;
using System.Windows.Forms;


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
            Application.EnableVisualStyles();


            var services = new ServiceCollection();
            ConfigureServices(services);
            var serviceProvider = services.BuildServiceProvider();

            var formPrincipal = serviceProvider.GetRequiredService<FormPrincipal>();
            Application.Run(formPrincipal);
        }

        private static void ConfigureServices(ServiceCollection services)
        {
            //Database
            var configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();
                
            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DB")));

            //Repositorys
            services.AddTransient<IInvestigadorRepository, InvestigadorRepository>();
            
            //Mappers
            services.AddTransient<IMapper<InvestigadorModel, Investigador>, MapperModelToInvestigadorEntity>();

            //Querys
            services.AddTransient<InvestigadorConDepartamentosQuery>();

            //Forms
            services.AddTransient<FormPrincipal>();
            services.AddTransient<FormInvestigadores>();
            services.AddTransient<FormAgregarEditarInvestigador>();
            services.AddTransient<FormAsistenciasInvestigador>();
        }
    }
}