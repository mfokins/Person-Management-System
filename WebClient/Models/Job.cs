using System.Text.Json.Serialization;

namespace WebClient.Models
{
    public class Job
    {
        public string JobTitle { get; set; }
        public int Salary { get; set; }
    }
}