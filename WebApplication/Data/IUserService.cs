using System.Threading.Tasks;
using WebApplication.Models;

namespace WebApplication.Data
{
    public interface IUserService
    {
        Task<User> ValidateUserAsync(string userName, string password);
    }
}