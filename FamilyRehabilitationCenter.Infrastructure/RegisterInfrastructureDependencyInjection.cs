using FamilyRehabilitationCenter.Domain.IRepositories;
using FamilyRehabilitationCenter.Domain.IRepositories.Base;
using FamilyRehabilitationCenter.Infrastructure.Data;
using FamilyRehabilitationCenter.Infrastructure.Repositories;
using FamilyRehabilitationCenter.Infrastructure.Repositories.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace FamilyRehabilitationCenter.Infrastructure
{
    public static class RegisterInfrastructureDependencyInjection
    {
        public static IServiceCollection AddInfrastructureDependencies(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(connectionString)); // Use SQL Server


            // Add All Repositories In DI Container
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddScoped<ICountryRepository, CountryRepository>();
            services.AddScoped<IRegionRepository, RegionRepository>();
            services.AddScoped<ICitiyRepository, CityRepository>();
            services.AddScoped<IDistrictRepository, DistrictRepository>();
            services.AddScoped<IMinistryEducationRepository, MinistryEducationRepository>();
            services.AddScoped<IMinistryEducationLevelRepository, MinistryEducationLevelRepository>();

            return services;
        }
    }
}
