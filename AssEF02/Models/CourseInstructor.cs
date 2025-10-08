using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssEF02.Models
{
    internal class CourseInstructor
    {
        public int InstId { get; set; }
        public Instructor Instructor { get; set; }

        public int CourseId { get; set; }
        public Course Course { get; set; }
        public int Evaluate { get; set; }
    }
}
