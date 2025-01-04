using Auth0Net.DependencyInjection;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;
using UserService.Services.ApiServices;

namespace UserServices.ExtensionMethods
{
    public static class AuthenticationInjection
    {
        public static IServiceCollection AddAuth0Injection(this IServiceCollection service, IConfiguration configuration)
        {
            string Domain = configuration["Auth0:Domain"];
            string Audience = configuration["Auth0:Audience"];
            string ClientId = configuration["Auth0:ClientId"];
            string ClientSecret = configuration["Auth0:ClientSecret"];
            service.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;

            }).AddJwtBearer(options =>
            {
                options.Authority = Domain;
                options.Audience = Audience;
             
            });

            service.AddAuth0AuthenticationClient(options =>
            {
                options.Domain = Domain;
                options.ClientId = ClientId;
                options.ClientSecret = ClientSecret;
            });
            service.AddAuth0ManagementClient()
                    .AddManagementAccessToken();
            //------------------------------------------------------------
            service.AddAuthorization();

            service.AddSingleton<IAuthorizationHandler, HasScopeHandler>();
            service.AddSingleton<IAuthTokenService,AuthTokenService>();
            return service;
        }

    }
}
