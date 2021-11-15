using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace WebApplication.Models
{
    public class Person
    {
        [Required]
        [JsonPropertyName("Id")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter name")]
        [JsonPropertyName("FirstName")]

        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please enter surname")]
        [JsonPropertyName("LastName")]

        public string LastName { get; set; }

        [JsonPropertyName("HairColor")] public string HairColor { get; set; }
        [JsonPropertyName("EyeColor")] public string EyeColor { get; set; }

        [Required, Range(0, int.MaxValue, ErrorMessage = "Please enter a value bigger than {0}")]
        [JsonPropertyName("Age")]

        public int Age { get; set; }

        [JsonPropertyName("Weight")] public float Weight { get; set; }
        [JsonPropertyName("Height")] public int Height { get; set; }

        [Required] [JsonPropertyName("Sex")] public string Sex { get; set; }
    }
}