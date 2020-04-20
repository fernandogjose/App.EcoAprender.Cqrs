using App.EcoAprender.Cqrs.Application.Comunicado.AppServices;
using App.EcoAprender.Cqrs.Application.Comunicado.Interfaces;
using App.EcoAprender.Cqrs.Application.Usuario.AppServices;
using App.EcoAprender.Cqrs.Application.Usuario.Interfaces;
using App.EcoAprender.Cqrs.Domain.Compartilhado.Interfaces.Repositories;
using App.EcoAprender.Cqrs.Domain.Compartilhado.Pipelines;
using App.EcoAprender.Cqrs.Domain.Comunicado.Interfaces.Repositories;
using App.EcoAprender.Cqrs.Domain.Usuario.Interfaces.Repositories;
using App.EcoAprender.Cqrs.Infra.Data.Dapper.Repositories;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;

namespace App.EcoAprender.Cqrs.Infra.CrossCutting.IoC
{
    public class BootStrapper
    {
        public static void RegisterServices(IServiceCollection services)
        {
            // Repository
            services.AddScoped<IDbConnection>(x => new SqlConnection(@"Data Source=sql4.porta80.com.br,1433;Initial Catalog=ecoaprender;Integrated Security=False;User ID=ecoaprender;Password=ahv5G2pH4a@;"));
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddTransient<IComunicadoRepository, ComunicadoRepository>();
            services.AddTransient<IUsuarioRepository, UsuarioRepository>();

            // Application
            services.AddTransient<IComunicadoAppService, ComunicadoAppService>();
            services.AddTransient<IUsuarioAppService, UsuarioAppService>();

            // Handler
            services.AddScoped(typeof(IPipelineBehavior<,>), typeof(ValidateCommand<,>));
            services.AddMediatR(Assembly.GetExecutingAssembly());
        }
    }
}
