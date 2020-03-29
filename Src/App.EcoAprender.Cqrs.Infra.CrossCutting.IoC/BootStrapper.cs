using App.EcoAprender.Cqrs.Application.AppServices;
using App.EcoAprender.Cqrs.Application.Interfaces;
using App.EcoAprender.Cqrs.Domain.Commands;
using App.EcoAprender.Cqrs.Domain.Handles;
using App.EcoAprender.Cqrs.Domain.Interfaces.Commands;
using App.EcoAprender.Cqrs.Domain.Interfaces.Repositories;
using App.EcoAprender.Cqrs.Infra.Data.Dapper.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System.Data;
using System.Data.SqlClient;

namespace App.EcoAprender.Cqrs.Infra.CrossCutting.IoC
{
    public class BootStrapper
    {
        public static void RegisterServices(IServiceCollection services)
        {
            // Repository
            services.AddScoped<IDbConnection>(x => new SqlConnection(@"Data Source=sql4.porta80.com.br;Initial Catalog=ecoaprender;Integrated Security=False;User ID=ecoaprender;Password=ahv5G2pH4a@;MultipleActiveResultSets=True;Connect Timeout=30;Encrypt=True;TrustServerCertificate=True"));
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddTransient<IAnuncioRepository, AnuncioRepository>();
            services.AddTransient<IComunicadoRepository, ComunicadoRepository>();

            // Application
            services.AddTransient<IComunicadoAppService, ComunicadoAppService>();

            // Command
            services.AddTransient<IRequestCommand, AnuncioAdicionarCommand>();

            // Handler
            services.AddTransient<AnuncioHandler, AnuncioHandler>();
        }
    }
}
