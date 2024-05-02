using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using XP.GestaoInvestimentos.Services;
using XP.GestaoInvestimentos.Services.Class;

namespace XP.GestaoInvestimentos.Injector
{
    public class DependencyInjector
    {
        #region [API]
        public static void Register(IServiceCollection services, IConfiguration configuration)
        {
            RegisterDbConnections(services, configuration);
            RegisterRepositories(services);
            RegisterServices(services);
        }

        private static void RegisterRepositories(IServiceCollection services)
        {
            #region GestaoInvestimentoRepositories
            
            #endregion
        }

        private static void RegisterServices(IServiceCollection services)
        {
            #region GestaoInvestimentoServices
            services.AddScoped<IUsuarioService, UsuarioService>();
            #endregion
        }

        private static void RegisterDbConnections(IServiceCollection services, IConfiguration configuration)
        {
            #region Database Context
            //services.AddDbContext<InvetimentoContext>(options => options.UseOracle(new SQLServerConn(
            //    configuration.GetSection("Connections:Investimento:Host").Value,
            //    configuration.GetSection("Connections:Investimento:Port").Value,
            //    configuration.GetSection("Connections:Investimento:ServiceName").Value,
            //    configuration.GetSection("Connections:Investimento:UserId").Value,
            //    configuration.GetSection("Connections:Investimento:Password").Value
            //    ).ToString()), ServiceLifetime.Singleton);
            #endregion
        }

        #endregion

        #region [Worker]
        public static void RegisterWorker(IServiceCollection services, IConfiguration configuration)
        {
            services.AddSingleton(configuration);

            #region Services

            #endregion

            #region Repositories
            #endregion

            #region Database Context
            //services.AddDbContext<InvetimentoContext>(options => options.UseOracle(new SQLServerConn(
            //    configuration.GetSection("Connections:Investimento:Host").Value,
            //    configuration.GetSection("Connections:Investimento:Port").Value,
            //    configuration.GetSection("Connections:Investimento:ServiceName").Value,
            //    configuration.GetSection("Connections:Investimento:UserId").Value,
            //    configuration.GetSection("Connections:Investimento:Password").Value
            //    ).ToString()), ServiceLifetime.Singleton);
            #endregion
        }
        #endregion
    }
}