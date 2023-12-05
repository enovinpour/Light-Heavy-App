using AutoMapper;
using GymApp.Services.Interfaces;
using GymApp.Services.Services.News;
using GymApp.Services.Services.Store;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace GymApp.Services
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddDependencyInjection(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            services.AddSingleton<INewsService, NewsService>();
            services.AddSingleton<IStoreService, StoreService>();

            return services;
        }
    }
}
