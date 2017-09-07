using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EightSpoons.Models
{
    public class EmployeeLocation
    {
        [ForeignKey("Employee")]
        public int EmployeeId { get; set; }

        [ForeignKey("Location")]
        public int LocationId { get; set; }


        public virtual Employee Employee { get; set; }
        public virtual Location Location { get; set; }
    }
}