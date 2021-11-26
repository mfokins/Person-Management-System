using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplication.Models;
using WebApplication.Persistence;

namespace WebApplication.Data.Impl
{
    public class AdultDBRepo : IAdultService
    {
        private readonly AdultDBContext ctx;

        public AdultDBRepo(AdultDBContext dbContext)
        {
            ctx = dbContext;

            Job job1 = new()
            {
                JobTitle = "Doctor",
                Salary = 90000
            };

            Job job3 = new()
            {
                JobTitle = "Officer",
                Salary = 54000
            };

            Job job2 = new()
            {
                JobTitle = "Teacher",
                Salary = 60000
            };

            Job job4 = new()
            {
                JobTitle = "Tourist",
                Salary = 1000
            };


            Adult adult1 = new Adult()
            {
                FirstName = "Jack",
                LastName = "Black",
                Age = 37,
                HairColor = "Black",
                EyeColor = "Gray",
                Height = 184,
                Weight = 92,
                Sex = "M",
                JobTitle = job1,
            };
            Adult adult2 = new Adult()
            {
                FirstName = "Anna",
                LastName = "Marrie",
                Age = 28,
                HairColor = "Blond",
                EyeColor = "Blue",
                Height = 178,
                Weight = 62,
                Sex = "F",
                JobTitle = job2,
            };
            Adult adult3 = new Adult()
            {
                FirstName = "Terry",
                LastName = "Starry",
                Age = 45,
                HairColor = "Bold",
                EyeColor = "Green",
                Height = 192,
                Weight = 88,
                Sex = "M",
                JobTitle = job3,
            };
            Adult adult4 = new Adult()
            {
                FirstName = "Sara",
                LastName = "Kerrigan",
                Age = 32,
                HairColor = "Red",
                EyeColor = "Green",
                Height = 174,
                Weight = 52,
                Sex = "Other",
                JobTitle = job4,
            };


            if (!ctx.Adults.Any())
            {
                ctx.Add(adult1);
                ctx.Add(adult2);
                ctx.Add(adult3);
                ctx.Add(adult4);
                ctx.SaveChanges();
            }
        }

        public async Task<IList<Adult>> GetAllAdultsAsync()
        {
            return await ctx.Adults.Include(a => a.JobTitle).ToListAsync();
        }

        public async Task<Adult> AddAdultAsync(Adult adult)
        {
            await ctx.Adults.AddAsync(adult);
            await ctx.SaveChangesAsync();
            return adult;
        }

        public async Task RemoveAdultAsync(int adultId)
        {
            ctx.Adults.Remove(await ctx.Adults.FirstAsync(c => c.Id.Equals(adultId)));
            await ctx.SaveChangesAsync();

            //removing also job left behind in database
            CleanupTheJobsTable();
        }

        public async Task<Adult> UpdateAsync(Adult adult)
        {
            try
            {
                ctx.Update(adult);
                await ctx.SaveChangesAsync();

                //removing also job left behind in database
                CleanupTheJobsTable();

                return adult;
            }
            catch (Exception)
            {
                throw new Exception($"Failed to find adult with id #{adult.Id}");
            }
        }

        public async Task<Adult> GetAdultAsync(int id)
        {
            return await ctx.Adults.Include(a => a.JobTitle).FirstAsync(t => t.Id == id);
        }

        private async void CleanupTheJobsTable()
        {
            //Method is removing previous jobs left behind in database
            //(Update method suddenly populates the table and this method purpose is to clean it up)

            foreach (Job job in ctx.Jobs)
            {
                if (!ctx.Adults.Any(a => a.JobTitle.JobID == job.JobID))
                {
                    ctx.Jobs.Remove(job);
                }
            }

            await ctx.SaveChangesAsync();
        }
    }
}