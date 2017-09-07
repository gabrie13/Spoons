using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace EightSpoons.Models
{
    public class RegisterViewModel
    {
        [Key]
        public int RegisterId { get; set; }

        public decimal Cash { get; set; }

        public decimal Check { get; set; }

        public decimal Visa { get; set; }

        public decimal MasterCard { get; set; }

        public decimal Discover { get; set; }

        public decimal Amex { get; set; }

        [Display(Name = "Gift Card")]
        public decimal GiftCard { get; set; }

        public decimal Tax { get; set; }

        [Display(Name = "Credit Total")]
        public decimal CcTotal { get; set; }

        public decimal Total { get; set; }
    }
}