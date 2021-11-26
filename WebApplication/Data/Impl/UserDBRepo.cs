using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplication.Models;
using WebApplication.Persistence;

namespace WebApplication.Data.Impl
{
    public class UserDBRepo : IUserService
    {
        private readonly AdultDBContext ctx;

        public UserDBRepo(AdultDBContext dbContext)
        {
            ctx = dbContext;

            User user1 = new User
            {
                UserName = "Admin",
                Password = "123456",
                SecurityLevel = 2
            };
            User user2 = new User
            {
                UserName = "User",
                Password = "123456",
                SecurityLevel = 1
            };

            if (!ctx.Users.Any())
            {
                ctx.Users.Add(user1);
                ctx.Users.Add(user2);
                ctx.SaveChangesAsync();
            }
        }


        public async Task<User> ValidateUserAsync(string username, string password)
        {
            User user = await ctx.Users.FirstOrDefaultAsync(user => user.UserName.Equals(username));
            if (user == null)
            {
                throw new Exception("User not found");
            }

            if (!user.Password.Equals(password))
            {
                throw new Exception("Incorrect password");
            }

            return user;
        }
    }
}