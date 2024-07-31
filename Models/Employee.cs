using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcApplicationRUTH.Models
{
    public class Employee
    {
        [Key]
        public int employeeNoID { get; set; }

        [Required]
        public string employeeName { get; set; }
    }
}