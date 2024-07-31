using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcApplicationRUTH.Models
{
    public class PaymentMethod
    {
        [Key]
        public int pMethodNoID { get; set; }

        [Required]
        public string methodName { get; set; }
    }
}