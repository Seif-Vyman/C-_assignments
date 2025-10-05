using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentEF01.Entities
{
    // Data Annotation
    internal class Topic
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }


    }
}
