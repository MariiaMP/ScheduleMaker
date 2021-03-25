using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ScheduleApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace ScheduleApp.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ScheduleContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<ScheduleContext>>()))
            {
                // Look for any movies.
                if (context.Users.Any())
                {
                    return;   // DB has been seeded
                }

                context.Users.AddRange(
                    new Users
                    {
                        id = 1,
                        name = "Iryna",
                        surname = "Shyhinska",
                        email = "ishyginska@gmail.com",
                        password = "12345678",
                        role = "user",
                        group = "PMI-35"
                    },

                    new Users
                    {
                        id = 2,
                        name = "Maria",
                        surname = "Pisotska",
                        email = "mpisotska@gmail.com",
                        password = "12345678",
                        role = "admin",
                        group = "none"
                    },

                    new Users
                    {
                        id = 3,
                        name = "Mariana",
                        surname = "Karabin",
                        email = "mkarabin@gmail.com",
                        password = "12345678",
                        role = "user",
                        group = "PMI-35"
                    },

                    new Users
                    {
                        id = 3,
                        name = "Yuriy",
                        surname = "Shcherbyna",
                        email = "yshcherbyna@gmail.com",
                        password = "12345678",
                        role = "teacher",
                        group = "none"
                    }
                ); ;
                context.SaveChanges();
            }
        }
    }
}
