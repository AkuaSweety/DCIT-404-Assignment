using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MvcApplicationRUTH.Models
{
    public class Registrations
    {
        [Key]
        public int registrationNoID { get; set; }
        public DateTime registrationDate { get; set; }
        public int delegateNoID { get; set; }
        public int courseFeeNoID { get; set; }
        public int registerEmployeeNoID { get; set; }
        public int courseNoID { get; set; }
        public virtual Delegate delegateNo { get; set; }
        public virtual CourseFee courseFeeNo { get; set; }
        public virtual Employee registerEmployeeNo { get; set; }
        public virtual Course courseNo { get; set; }
    }
}