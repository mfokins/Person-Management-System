using System.Threading.Tasks;
using WebApplication.Models;

namespace WebApplication.Data
{
    public interface IUserService
    {
        Task<User> ValidateUser(string userName, string password);
        // User GetUser(int userId);
    }
}