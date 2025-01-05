using Microsoft.EntityFrameworkCore;

namespace NotificationService.ExtensionMethods
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddDependency(this IServiceCollection services)
        {
            return services;
        }
        public static IServiceCollection AddDatabase(this IServiceCollection services, IConfiguration configuration)
        {
            string? connectionService = configuration.GetConnectionString("Default");
            services.AddDbContext<DataContext>(option =>
                         option.UseSqlServer(connectionService));
            //injection des repository
            return services;    
        }

        public static IServiceCollection AddRepository(this IServiceCollection services, IConfiguration configuration) 
        { 
            return services;
        }

        public static IServiceCollection AddServices(this IServiceCollection services) 
        {
            return services;
        }
    }
}
