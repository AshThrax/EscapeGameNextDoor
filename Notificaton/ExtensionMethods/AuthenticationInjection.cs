using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using NotificationService.Services.ApiService;
using NotificationService.Services.ApiServices;


namespace NotificationService.ExtensionMethods
{
    public static class AuthenticationInjection
    {
        public static IServiceCollection AddAuth0Injection(this IServiceCollection services, IConfiguration configuration)
        {
            string Domain= configuration["Auth0:Domain"];
            string Audience= configuration["Auth0:Audience"];

            services.AddAuthentication(options => 
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;

            }).AddJwtBearer(options => 
            {
                options.Authority = Domain;
                options.Audience=Audience;
             
            });

            services.AddAuthorization();

            services.AddSingleton<IAuthorizationHandler, HasScopeHandler>();
            services.AddSingleton<IAuthTokenService,AuthTokenService>();
            return services;
        }

    }
}
