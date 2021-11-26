using System.Text.Json.Serialization;

namespace WebClient.Models
{
    public class Adult : Person
    {
        public Job JobTitle { get; set; }
    }
}