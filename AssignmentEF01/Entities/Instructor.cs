using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentEF01.Entities
{
    // FLuent-APIs
    internal class Instructor
    {
        public int Id { get; set; }

        public string? Name { get; set; }
        public decimal Bouns { get; set; }
        public decimal Salary { get; set; }
        public string Address { get; set; }
        public double HourRate { get; set; }
        public int Dept_Id { get; set; }

    }
}
