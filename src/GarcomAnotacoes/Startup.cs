using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using GarcomAnotacoes.Configurations;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace GarcomAnotacoes
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbConfig(Configuration);

            services.AddDependencies();

            services.AddMvcConfig();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseMvcConfig(env);
        }
    }
}