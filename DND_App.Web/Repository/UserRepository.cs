using DND_App.Web.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace DND_App.Web.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly UserDbContext userDbContext;

        public UserRepository(UserDbContext userDbContext)
        {
            this.userDbContext = userDbContext;
        }
        public async Task<IEnumerable<IdentityUser>> GetAllUsers()
        {
            var users = await userDbContext.Users.ToListAsync();

            var adminUser = await userDbContext.Users
                .FirstOrDefaultAsync(u => u.Email == "dadsathome1@gmail.com");

            if (adminUser != null)
            {
                users.Remove(adminUser);
            }

            return users;
        }
    }
}
