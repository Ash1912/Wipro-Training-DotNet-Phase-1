using Day9Assignment1.Models;
using Microsoft.EntityFrameworkCore;

namespace Day9Assignment1.Services
{
    public class UserService : IUserService
    {
        private readonly UserDbContext _context;

        public UserService(UserDbContext context)
        {
            _context = context;
        }

        public async Task<bool> Register(string username, string password)
        {
            if (await _context.Users.AnyAsync(u => u.Username == username))
                return false;

            var user = new User { Username = username, HashedPassword = User.HashPassword(password) };
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Authenticate(string username, string password)
        {
            var user = await _context.Users.FirstOrDefaultAsync(u => u.Username == username);
            return user != null && User.VerifyPassword(password, user.HashedPassword);
        }
    }
}
