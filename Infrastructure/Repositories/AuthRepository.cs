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
            => await _context.Users.FirstOrDefaultAsync(u => u.UserName == username);

        public async Task AddUserAsync(User user)
            => await _context.Users.AddAsync(user);

        public async Task<bool> UserExistsAsync(string username)
            => await _context.Users.AnyAsync(u => u.UserName == username);

        public async Task SaveChangesAsync()
            => await _context.SaveChangesAsync();
    }
}
