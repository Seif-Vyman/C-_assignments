using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentEF01.Entities
{

    [Keyless]
    internal class Course_Inst
    {
        
        public int Inst_ID { get; set; }
        public int Course_ID { get; set; }
        [Precision(18, 2)]
        public decimal Evaluate { get; set; }


    }
}
