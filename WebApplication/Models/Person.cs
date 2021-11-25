using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace WebApplication.Models
{
    public class Person
    {
        [Required, Key] public int Id { get; set; }

        [Required(ErrorMessage = "Please enter name")]

        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please enter surname")]

        public string LastName { get; set; }

        public string HairColor { get; set; }
        public string EyeColor { get; set; }

        [Required, Range(0, int.MaxValue, ErrorMessage = "Please enter a value bigger than {0}")]

        public int Age { get; set; }

        public float Weight { get; set; }
        public int Height { get; set; }

        [Required] public string Sex { get; set; }
    }
}