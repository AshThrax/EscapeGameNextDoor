using Microsoft.AspNetCore.Identity;
using System.Security.Claims;
using UserService.Data;

namespace UserService.ExtensionMethods
{
    public static class MinimalApiExtension
    {
        /// <summary>
        /// add minal endpoint for specification
        /// </summary>
        /// <param name="application"></param>
        /// <returns></returns>
        public static WebApplication AddMinimalEndpoint(this WebApplication application)
        {
            application.MapIdentityApi<ApplicationUser>();
            application.MapPost("/logout", async (SignInManager<ApplicationUser> signInManager) => 
            {
                 await signInManager.SignOutAsync();
                return Results.Ok();
            }).RequireAuthorization();


            application.MapGet("/pingauth",(ClaimsPrincipal user) => 
            {
                var email= user.FindFirst(ClaimTypes.Email);
                return Results.Json(new {Email=email});
            }).RequireAuthorization();

            return application;
        }
    }
}
