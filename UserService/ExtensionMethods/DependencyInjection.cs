using Microsoft.EntityFrameworkCore;
using UserService.Data;

namespace UserService.ExtensionMethods
{
    public static class DependencyInjection
    {

        public static IServiceCollection AddDatabase(this IServiceCollection services,IConfiguration configuration)
        {
            string? connection = configuration.GetConnectionString("Default");
            
            services.AddDbContext<DataContext>(options=> options.UseSqlServer(connection));

            return services;
        }
        public static IServiceCollection AddRepository(this IServiceCollection services, IConfiguration configuration)
        {
            return services;
        }
        public static IServiceCollection AddServices(this IServiceCollection services, IConfiguration configuration) 
        {
            return services;
        }
    }
}
