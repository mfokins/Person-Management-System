using System.Collections.Generic;
using System.Threading.Tasks;
using WebClient.Models;

namespace WebClient.Data
{
    public interface IAdultService
    {
        Task<IList<Adult>> GetAllAdultsAsync();
        Task AddAdultAsync(Adult adult);
        Task RemoveAdultAsync(int id);
        Task UpdateAsync(Adult adult);

        Task<Adult> GetAdultAsync(int id);
    }
}