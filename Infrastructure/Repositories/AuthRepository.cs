using Microsoft.EntityFrameworkCore;
using Tripzy.Core.Models;
using Tripzy.Core.Repositories;
using Tripzy.Infrastructure.Data;

namespace Tripzy.Infrastructure.Repositories
{
    public class AuthRepository : IAuthRepository
    {
        private readonly AppDbContext _context;

        public AuthRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<User?> GetUserByUsernameAsync(string username)
            => await _context.User.FirstOrDefaultAsync(u => u.UserName == username);

        public async Task AddUserAsync(User user)
            => await _context.User.AddAsync(user);

        public async Task<bool> UserExistsAsync(string username)
            => await _context.User.AnyAsync(u => u.UserName == username);

        public async Task SaveChangesAsync()
            => await _context.SaveChangesAsync();
    }
}
