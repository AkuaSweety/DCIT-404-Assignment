using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcApplicationRUTH.Models
{
    public class Client
    {
        [Key]
        public int clientNoID { get; set; }

        [Required]
        public string clientName { get; set; }
    }
}