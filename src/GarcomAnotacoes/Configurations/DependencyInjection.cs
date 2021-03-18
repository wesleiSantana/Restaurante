using GarcomAnotacoes.Data;
using GarcomAnotacoes.Services;
using GarcomAnotacoes.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using GarcomAnotacoes.Interfaces.Services;
using GarcomAnotacoes.Interfaces.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace GarcomAnotacoes.Configurations
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddDbConfig(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<Context>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            });

            return services;
        }

        public static IServiceCollection AddDependencies(this IServiceCollection services)
        {
            // repositries
            services.AddScoped<ICopaRepository, CopaRepository>();
            services.AddScoped<IPedidoRepository, PedidoRepository>();
            services.AddScoped<ICozinhaRepository, CozinhaRepository>();

            // services
            services.AddScoped<ICopaService, CopaService>();
            services.AddScoped<IPedidoService, PedidoService>();
            services.AddScoped<ICozinhaService, CozinhaService>();

            return services;
        }
    }
}
