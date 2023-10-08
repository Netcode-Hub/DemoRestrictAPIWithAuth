using DemoRestrictAPIWithAuth.Models;
namespace DemoRestrictAPIWithAuth.Services
{
    public interface IClientService
    {
        Task<(bool flag, string Message)> RegisterUserAsync(Registration model);
        Task<(bool flag, string Token)> LoginUserAsync(Login model);
    }
}
