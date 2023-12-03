using Microsoft.Extensions.DependencyInjection;

namespace SisRHDefinitivo.Core.Repository
{
    public static class ContainerConfig
    {
        public static IServiceCollection AddCoreSisRHDaependencies(this IServiceCollection services)
        {
            services.AddScoped<IFuncionarioRepository, FuncionarioRepository>();


            //services.AddScoped<ILoginRepository, LoginRepository>();


            return services;
        }
    }
}
