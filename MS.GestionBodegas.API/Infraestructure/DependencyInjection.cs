using Application.Common.Interfaces;
using Infraestructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infraestructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfraestructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<GestionBodegasDBContext>(options => options.UseSqlServer
            (
                configuration.GetConnectionString("Default"),
                b => b.MigrationsAssembly(typeof(GestionBodegasDBContext).Assembly.FullName))
            );

            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            return services;
        }
    }
}