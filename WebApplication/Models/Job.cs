using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;

namespace WebApplication.Models
{
    public class Job
    {
        [ForeignKey("JobID")]
        public int JobID { get; set; }
        public string JobTitle { get; set; }
        public int Salary { get; set; }
    }
}