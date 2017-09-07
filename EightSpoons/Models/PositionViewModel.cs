using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace EightSpoons.Models
{
    public class PositionViewModel
    {
        [Key]
        public int PositionId { get; set; }

        [Display(Name = "Position")]
        public string PositionTitle { get; set; }
    }
}