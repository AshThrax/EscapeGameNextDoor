using CloudinaryDotNet;
using EscapeGameService.Models.Params;
using EscapeGameService.Repository.EscapeGame;
using EscapeGameService.Services.Escapesgame;
using Microsoft.Extensions.Options;
using Microsoft.Identity.Client;

namespace EscapeGameService.ExtensionMethods
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddDependency(this IServiceCollection services)
        {
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped<IEscapeRepository, EscapeRepository>();
            services.AddScoped<IEscapeGameServices,EscapeGameServices>();
            return services;
        }
        public static IServiceCollection AddDatabase(this IServiceCollection services,IConfiguration config)
        {
            services.AddDbContext<DataContext>(option =>
                         option.UseSqlServer(config.GetConnectionString("Default")));
            //injection des repository
            return services;
        }
        public static IServiceCollection AddCloudinaryEscape(this IServiceCollection services, IConfiguration config)
        {
            var CloudConfig = new CloudDinarySettings();
            config.GetSection("Cloudinary")
                .Bind(CloudConfig);

            services
                .Configure<CloudDinarySettings>(options => 
                {
                    options.Cloud = CloudConfig.Cloud;
                    options.ApiKey = CloudConfig.ApiKey;
                    options.ApiSecret =CloudConfig.ApiSecret;
                });
            services.AddScoped<ICloudinaryService, CloudinaryService>();

            return services;
        }


    }
}
