using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentEF01.Entities
{
    // Data Annotation
    internal class Department
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string? Name { get; set; }
        public int Ins_ID { get; set; }
        public DateTime HiringDate { get; set; }

    }
}
