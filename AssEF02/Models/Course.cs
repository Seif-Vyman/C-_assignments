using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssEF02.Models
{
    //Convention-Based
    internal class Course
    {
        public int Id { get; set; }
        public double Duration { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public int TopicId { get; set; }
        public Topic Topic { get; set; }

        public ICollection<CourseInstructor> CourseInstructors { get; set; }
        public ICollection<StudentCourse> Students { get; set; }
    }
}
