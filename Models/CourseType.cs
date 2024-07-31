using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcApplicationRUTH.Models
{
    public class CourseType
    {
          [Key]
        public int courseTypeNoID { get; set; }

        [Required]
        public string courseTypeDescription { get; set; }
    }
}