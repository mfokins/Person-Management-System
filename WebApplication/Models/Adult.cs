using System.Text.Json.Serialization;

namespace WebApplication.Models {
public class Adult : Person {
    [JsonPropertyName("JobTitle")]
    public Job JobTitle { get; set; }
}
}