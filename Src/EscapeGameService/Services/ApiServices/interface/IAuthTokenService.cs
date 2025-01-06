namespace EscapeGameService.Services.ApiServices
{
    public interface IAuthTokenService
    {
         Task<string> GetSub();
    }
}
