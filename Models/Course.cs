using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MvcApplicationRUTH.Models
{
    public class Course
    {
        [Key]
        public int courseNoID { get; set; }
        public string courseName { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public TimeSpan endTime { get; set; }
        public int maxDelegates { get; set; }
        public Char confirmed { get; set; }
        public int delivererEmployeeNoID { get; set; }
        public int courseTypeNoID { get; set; }
        public virtual Employee delivererEmployeeNo { get; set; }
        public virtual CourseType courseTypeNo { get; set; }

    }
}