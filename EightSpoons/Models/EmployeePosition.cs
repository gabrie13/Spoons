using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace EightSpoons.Models
{
    public class EmployeePosition
    {
        [Key]
        public int EmployeePositionId { get; set; }

        [ForeignKey("Employee")]
        public int Employeeid { get; set; }

        [ForeignKey("Position")]
        public int PositionId { get; set; }


        public virtual Employee Employee { get; set; }
        public virtual Position Position { get; set; }
    }
}