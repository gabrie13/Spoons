using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EightSpoons.Models
{
    public class EmployeeRegister
    {
        [ForeignKey("Employee")]
        public int EmployeeId { get; set; }
        
        [ForeignKey("Register")]
        public int RegisterId { get; set; }

        
        public virtual Employee Employee { get; set; }
        public virtual Register Register { get; set; }

    }
}