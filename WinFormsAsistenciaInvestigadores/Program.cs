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
using ApplicationBussines.UseCasesInvestigador;
using ApplicationBussines.UseCasesAsistencia;


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
            Application.SetCompatibleTextRenderingDefault(false);


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
            services.AddTransient<IRepository<Departamento>, DepartamentoRepository>();
            services.AddTransient<IAsistenciaRepository, AsistenciaRepository>();

            //Mappers
            services.AddTransient<IMapper<InvestigadorModel, Investigador>, MapperModelToInvestigadorEntity>();

            //Querys
            services.AddTransient<InvestigadorConDepartamentosQuery>();

            //Use Cases
            services.AddTransient<AddInvestigador>();
            services.AddTransient<EditInvestigador>();
            services.AddTransient<SoftDeleteInvestigador>();
            services.AddTransient<SoftRestoreInvestigador>();
            services.AddTransient<AddAsistencia>();
            services.AddTransient<EditAsistencia>();
            services.AddTransient<DeleteAsistencia>();

            //Forms
            services.AddTransient<FormPrincipal>();
            services.AddTransient<FormInvestigadores>();
            services.AddTransient<FormAgregarEditarInvestigador>();
            services.AddTransient<FormAgregarEditarAsistencia>();
            services.AddTransient<FormAsistenciasInvestigador>();
        }
    }
}