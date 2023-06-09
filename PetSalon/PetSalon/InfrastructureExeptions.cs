using PetInfrastructure;
using Microsoft.EntityFrameworkCore;

namespace PetSalon
{
    public static class InfrastructureExeptions
    {
        public static IServiceCollection RegisterDataBase(this IServiceCollection services)
        {
            var dbConnectionString = "User ID=postgres; Password=dream; Host=localhost; Port=5434; Database=PetsDb;";
            services.AddDbContext<AppDbContext>((serviceProvider, options) =>
            {
                var currentAssemblyName = typeof(AppDbContext).Assembly.FullName;
                options.UseNpgsql(
                    dbConnectionString,
                    b => b.MigrationsAssembly("PetSalon"));
            });

            return services;
        }
    }
}
