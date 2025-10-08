using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssEF02.Models
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

        public int DeptId { get; set; }
        public Department Department { get; set; }

        public ICollection<CourseInstructor> CourseInstructors { get; set; }

        public Department DepartmentManaged { get; set; }
    }
}
