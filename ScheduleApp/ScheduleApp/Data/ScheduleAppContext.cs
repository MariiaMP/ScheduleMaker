﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ScheduleApp.Models;

namespace ScheduleApp.Data
{
    public class ScheduleAppContext : DbContext
    {
        public ScheduleAppContext (DbContextOptions<ScheduleAppContext> options)
            : base(options)
        {
        }

        public DbSet<ScheduleApp.Models.Users> Users { get; set; }
        public DbSet<ScheduleApp.Models.Subjects> Subjects { get; set; }
        public DbSet<ScheduleApp.Models.Group> Groups { get; set; }
        public DbSet<ScheduleApp.Models.Teachers> Teachers { get; set; }
        public DbSet<ScheduleApp.Models.SubjectTeacher> SubjectTeachers { get; set; }
        public DbSet<ScheduleApp.Models.SubjectGroup> SubjectGroups { get; set; }
    }
}
