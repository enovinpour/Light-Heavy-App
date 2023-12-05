using GymApp.Api.Configuration;
using GymApp.Api.News;
using GymApp.Api.Store;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Refit;
using System.Text.Json;

namespace GymApp.Api
{
    public static class ApiServiceCollectionExtension
    {
        public static void AddApiConfiguration(IConfigurationBuilder configuration)
        {
            configuration.AddJsonFile("apisettings.json", optional: true);
        }

        /// <summary>
        /// Set up Refit for APIs
        /// </summary>
        /// <param name="services"></param>
        public static void ConfigureApis(IServiceCollection services)
        {
            services.AddRefitClientBuilder<INewsApi>(ApiConfig.NewsConfig);
            services.AddRefitClientBuilder<IStoreApi>(ApiConfig.StoreConfig);
        }

        /// <summary>
        /// Extention class for Refit client set up
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="services"></param>
        /// <param name="apiStringName"></param>
        /// <returns></returns>
        public static IHttpClientBuilder AddRefitClientBuilder<T>(this IServiceCollection services, string apiStringName) where T : class
        {
            var jsonSerializerOptions = new JsonSerializerOptions
            {
                //set some options such as your preferred naming style...
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = true
            };

            return services
            .AddRefitClient<T>(new RefitSettings(new SystemTextJsonContentSerializer(jsonSerializerOptions), null, null))
            .ConfigureHttpClient((services, httpClient) =>
            {
                var rootConfig = services.GetRequiredService<IConfiguration>();
                var apiConfig = rootConfig.GetRequiredSection(apiStringName).Get<ApiConfig>();

                httpClient.BaseAddress = new Uri(apiConfig.Url);
            });
        } 
    }
}
