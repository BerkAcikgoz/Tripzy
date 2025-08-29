using Tripzy.Core.Models;

namespace Tripzy.Core.Services
{
    public interface IAuthService
    {
        Task<User?> Register(string username, string password);
        Task<string?> Login(string username, string password);
    }
}