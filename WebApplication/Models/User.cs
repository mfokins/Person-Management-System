using System.Text.Json.Serialization;

namespace WebApplication.Models
{
    public class User
    {
        [JsonPropertyName("UserName")] public string UserName { get; set; }
        [JsonPropertyName("SecurityLevel")] public int SecurityLevel { get; set; }
        [JsonPropertyName("UserId")] public int UserId { get; set; }
        [JsonPropertyName("Password")] public string Password { get; set; }
    }
}