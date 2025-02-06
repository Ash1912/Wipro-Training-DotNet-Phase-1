using Microsoft.EntityFrameworkCore;
using MVCNlog.Models;

namespace MVCNlog.Services
{
    public class UserService
    {
        private readonly UserDbContext _context;

        // Inject the DbContext into the service
        //Custom Service Injection
        public UserService(UserDbContext context)
        {
            _context = context;
        }

        public async Task<bool> Register(string username, string password)
        {
            var existingUser = await _context.Users.FirstOrDefaultAsync(u => u.Username == username);
            if (existingUser != null)
            {
                // User already exists
                return false;
            }

            string hashedPassword = User.HashPassword(password);
            var user = new User { Username = username, HashedPassword = hashedPassword };
            _context.Users.Add(user);
            await _context.SaveChangesAsync();  // Save the new user to the database
            return true;
        }

        public async Task<bool> Authenticate(string username, string password)
        {
            var user = await _context.Users.FirstOrDefaultAsync(u => u.Username == username);
            if (user == null) return false;

            return User.VerifyPassword(password, user.HashedPassword);
        }
    }
}
