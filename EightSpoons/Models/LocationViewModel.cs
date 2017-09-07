using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace EightSpoons.Models
{
    public class LocationViewModel
    {
        [Key]
        public int LocationId { get; set; }

        [Display(Name = "Location")]
        public string LocationName { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        [Display(Name = "Postal")]
        public string ZipCode { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }
    }
}