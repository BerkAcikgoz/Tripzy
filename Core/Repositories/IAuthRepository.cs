using Tripzy.Core.Models;

namespace Tripzy.Core.Repositories
{
    public interface IAuthRepository
    {
        Task<User?> GetUserByUsernameAsync(string username);
        Task AddUserAsync(User user);
        Task<bool> UserExistsAsync(string username);
        Task SaveChangesAsync();
    }
}