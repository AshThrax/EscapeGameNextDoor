
using System.Security.Claims;

namespace EscapeGameService.Services.ApiServices
{
    public class AuthTokenService : IAuthTokenService
    {
        private readonly IHttpContextAccessor _contextAccessor;
        public AuthTokenService(IHttpContextAccessor contextAccessor)
        {
            _contextAccessor = contextAccessor
                ?? throw new ArgumentNullException(nameof(_contextAccessor));
        }

        public async Task<string> GetSub()
        {

            string? subClaim = _contextAccessor?.HttpContext?
                .User.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? "";
            return subClaim;
        }
    }
}
