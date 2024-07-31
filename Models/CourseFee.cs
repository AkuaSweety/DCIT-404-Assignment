using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MvcApplicationRUTH.Models
{
    public class CourseFee
    {
        [Key]
        public int courseFeeNoID { get; set; }
        public string feeDescription { get; set; }
        public Decimal fee { get; set; }
        public int courseNoID { get; set; }
        public virtual Course courseNo { get; set; }
    }
}