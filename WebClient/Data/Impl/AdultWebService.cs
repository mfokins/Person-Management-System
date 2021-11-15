using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using WebClient.Models;

namespace WebClient.Data.Impl
{
    public class AdultWebService : IAdultService
    {
        private string uri = "https://localhost:5003";
        private readonly HttpClient client;

        public AdultWebService()
        {
            client = new HttpClient();
        }

        public async Task<IList<Adult>> GetAllAdultsAsync()
        {
            Task<string> stringAsync = client.GetStringAsync(uri + "/Adults");
            string message = await stringAsync;
            List<Adult> result = JsonSerializer.Deserialize<List<Adult>>(message);
            return result;
        }

        public async Task AddAdultAsync(Adult adult)
        {
            string adultAsJson = JsonSerializer.Serialize(adult);
            HttpContent content = new StringContent(adultAsJson,
                Encoding.UTF8,
                "application/json");
            await client.PostAsync(uri + "/Adults", content);
        }

        public async Task RemoveAdultAsync(int adultId)
        {
            await client.DeleteAsync($"{uri}/Adults/{adultId}");
        }

        public async Task UpdateAsync(Adult adult)
        {
            string adultAsJson = JsonSerializer.Serialize(adult);
            HttpContent content = new StringContent(adultAsJson,
                Encoding.UTF8,
                "application/json");
            await client.PatchAsync($"{uri}/Adults/{adult.Id}", content);
        }

        public async Task<Adult> GetAdultAsync(int id)
        {
            Task<string> stringAsync = client.GetStringAsync($"{uri}/Adults/{id}");
            string message = await stringAsync;
            Adult result = JsonSerializer.Deserialize<Adult>(message);
            return result;
        }
    }
}