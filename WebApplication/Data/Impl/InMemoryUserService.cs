using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Models;

namespace WebApplication.Data.Impl
{
    public class InMemoryUserService : IUserService
    {
        private static List<User> users;

        public InMemoryUserService()
        {
            users = new[]
            {
                new User
                {
                    Password = "123456",
                    SecurityLevel = 2,
                    UserId = 1,
                    UserName = "Admin"
                },
                new User
                {
                    Password = "123456",
                    SecurityLevel = 1,
                    UserId = 2,
                    UserName = "User"
                }
            }.ToList();
        }

        public async Task<User> ValidateUser(string userName, string password)
        {
            User first = users.FirstOrDefault(user => user.UserName.Equals(userName));
            if (first == null)
            {
                throw new Exception("User not found");
            }

            if (!first.Password.Equals(password))
            {
                throw new Exception("Incorrect password");
            }

            return first;
        }
    }
}