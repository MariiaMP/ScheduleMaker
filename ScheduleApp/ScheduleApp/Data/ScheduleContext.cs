using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ScheduleApp.Models;

namespace ScheduleApp.Data
{
    public class ScheduleContext : DbContext
    {
        public ScheduleContext (DbContextOptions<ScheduleContext> options)
            : base(options)
        {
        }

        public DbSet<ScheduleApp.Models.Schedule> Schedule { get; set; }
    }
}
