using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using WebApplication.Models;
using WebApplication.Persistence;

namespace WebApplication.Data.Impl
{
    public class AdultService : IAdultService
    {
        private readonly FileContext _fileContext;
        private readonly IList<Adult> _adults;

        public AdultService(FileContext fileContext)
        {
            _fileContext = fileContext;
            _adults = _fileContext.Adults;
        }

        public async Task<IList<Adult>> GetAllAdultsAsync()
        {
            return new List<Adult>(_adults);
        }

        public async Task<Adult> AddAdultAsync(Adult adult)
        {
            int max = _adults.Max(adult => adult.Id);
            adult.Id = (++max);
            _adults.Add(adult);
            _fileContext.SaveChanges();
            return adult;
        }

        public async Task RemoveAdultAsync(int adultId)
        {
            Adult toRemove = _adults.First(t => t.Id == adultId);
            _adults.Remove(toRemove);
            _fileContext.SaveChanges();
        }

        public async Task<Adult> UpdateAsync(Adult adult)
        {
            Adult toUpdate = _adults.First(t => t.Id == adult.Id);
            toUpdate.JobTitle = adult.JobTitle;
            toUpdate.FirstName = adult.FirstName;
            toUpdate.LastName = adult.LastName;
            toUpdate.Age = adult.Age;
            toUpdate.Sex = adult.Sex;
            toUpdate.Weight = adult.Weight;
            toUpdate.Height = adult.Height;
            toUpdate.HairColor = adult.HairColor;
            toUpdate.EyeColor = adult.EyeColor;
            _fileContext.SaveChanges();
            return toUpdate;
        }
        
        public async Task<Adult> GetAdultAsync(int id)
        {
            return _adults.FirstOrDefault(t => t.Id == id);
        }
    }
}