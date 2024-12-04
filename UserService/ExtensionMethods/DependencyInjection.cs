using Microsoft.EntityFrameworkCore;
using UserService.Data;

namespace UserService.ExtensionMethods
{
    public static class DependencyInjection
    {

        public static IServiceCollection AddService(this IServiceCollection services,IConfiguration configuration)
        {
            string connection = configuration.GetConnectionString("Default");

            services.AddDbContext<DataContext>(options=> options.UseSqlServer(connection));

            return services;
        }
    }
}
