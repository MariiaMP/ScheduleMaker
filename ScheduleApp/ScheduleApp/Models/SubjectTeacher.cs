using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScheduleApp.Models
{
    public class SubjectTeacher
    {
        public int id { get; set; }
        public int subject_id { get; set; }
        public int teacher_id { get; set; }
    }
}
