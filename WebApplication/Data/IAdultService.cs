using System.Collections.Generic;
using System.Dynamic;
using System.Threading.Tasks;
using WebApplication.Models;

namespace WebApplication.Data
{
    public interface IAdultService
    {
        Task<IList<Adult>> GetAllAdultsAsync(); 
        Task<Adult> AddAdultAsync(Adult adult);
        Task RemoveAdultAsync(int adultId);
        Task<Adult> UpdateAsync(Adult adult);
        Task<Adult> GetAdultAsync(int id);
    }
}