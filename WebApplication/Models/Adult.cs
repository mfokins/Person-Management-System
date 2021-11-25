using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.Design;
using System.Text.Json.Serialization;

namespace WebApplication.Models {
public class Adult : Person {
    public Job Job { get; set; }
}
}