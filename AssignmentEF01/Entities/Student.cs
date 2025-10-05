using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentEF01.Entities
{
    // Class Configuration
    internal class Student
    {
        public int Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Address { get; set; }
        [Range(18,60)]
        public int Age { get; set; }
        public int Dept_ID { get; set; }

    }
}
