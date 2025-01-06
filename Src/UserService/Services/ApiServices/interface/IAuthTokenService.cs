namespace UserService.Services.ApiServices
{
    public interface IAuthTokenService
    {
        Task<string> GetSub();
    }
}
