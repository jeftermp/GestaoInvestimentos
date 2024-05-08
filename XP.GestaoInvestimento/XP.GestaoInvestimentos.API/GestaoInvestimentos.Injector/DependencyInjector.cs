using GestaoInvestimentos.Infrastructure.Context;
using GestaoInvestimentos.Infrastructure.Repository.Class;
using GestaoInvestimentos.Infrastructure.Repository.Interface;
using GestaoInvestimentos.Services;
using GestaoInvestimentos.Services.Class;
using GestaoInvestimentos.Services.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace GestaoInvestimentos.Injector
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
            services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
            services.AddScoped<IClienteRepository, ClienteRepository>();
            services.AddScoped<IProdutoRepository, ProdutoRepository>();
            #endregion
        }

        private static void RegisterServices(IServiceCollection services)
        {
            #region GestaoInvestimentoServices
            services.AddScoped(typeof(IBaseService<>), typeof(BaseService<>));
            services.AddScoped<IUsuarioService, UsuarioService>();
            services.AddScoped<IClienteService, ClienteService>();
            services.AddScoped<IProdutoService, ProdutoService>();
            #endregion
        }

        private static void RegisterDbConnections(IServiceCollection services, IConfiguration configuration)
        {
            #region Database Context
            services.AddDbContext<InvestimentoContext>(options =>
            {
                options.UseSqlServer(configuration.GetSection("Connections:SqlServerInLine").Value,
                            sqlServerOptionsAction: sqlOptions =>
                            {
                                sqlOptions.EnableRetryOnFailure(); // Add if needed
                            });
            });
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