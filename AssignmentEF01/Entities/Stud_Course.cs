using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentEF01.Entities
{
    // convention-Based
    [Keyless]
    internal class Stud_Course
    {
        public int Stud_ID { get; set; }
        public int Course_ID { get; set; }
        public double Grade { get; set; }

    }
}
