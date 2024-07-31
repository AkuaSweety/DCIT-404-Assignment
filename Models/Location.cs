using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace MvcApplicationRUTH.Models
{
    public class Location
    {
        [Key]
        public int locationNoID { get; set; }

        [Required]
        public string locationName { get; set; }
    }
}