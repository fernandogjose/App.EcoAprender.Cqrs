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
            services.AddScoped<IDbConnection>(x => new SqlConnection(@"Data Source=sql4.porta80.com.br,1433;Initial Catalog=ecoaprender;Integrated Security=False;User ID=ecoaprender;Password=ahv5G2pH4a@;"));
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddTransient<IAnuncioRepository, AnuncioRepository>();
            services.AddTransient<IComunicadoRepository, ComunicadoRepository>();
            services.AddTransient<IUsuarioRepository, UsuarioRepository>();

            // Application
            services.AddTransient<IComunicadoAppService, ComunicadoAppService>();
            services.AddTransient<ILoginAppService, LoginAppService>();

            // Command
            services.AddTransient<IRequestCommand, AnuncioAdicionarCommand>();

            // Handler
            services.AddTransient<AnuncioHandler, AnuncioHandler>();
        }
    }
}
