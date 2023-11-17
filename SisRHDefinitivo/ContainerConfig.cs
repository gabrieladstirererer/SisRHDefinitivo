using SisRHDefinitivo.Repository;

namespace SisRHDefinitivo
{
    public static class ContainerConfig
    {
        public static IServiceCollection AddCoreSisRHDaependencies(this IServiceCollection services)
        {
            services.AddScoped<IFuncionarioRepository, FuncionarioRepository>();

            return services;
        }
    }
}
