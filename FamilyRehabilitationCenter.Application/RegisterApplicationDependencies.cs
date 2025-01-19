using FamilyRehabilitationCenter.Application.Common.Behaviours;
using FamilyRehabilitationCenter.Application.Services;
using FamilyRehabilitationCenter.Application.Services.IServices;
using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace FamilyRehabilitationCenter.Application
{
    public static class RegisterApplicationDependencies
    {
        public static IServiceCollection AddApplicationDependencies(this IServiceCollection services)
        {
            // Add MediaR in DI contianer
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));

            // Configuration for AutoMapper
            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));


            // Add Services to DI Contianer
            services.AddScoped<ISharedServices, SharedServices>();
            services.AddScoped<IMinistryEducationServices, MinistryEducationServices>();

            return services;
        }
    }
}
