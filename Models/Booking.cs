using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MvcApplicationRUTH.Models
{
    public class Booking
    {
         [Key]
        public int bookingNoID { get; set; }
        public DateTime bookingDate { get; set; }
        public int locationNoID { get; set; }
        public int courseNoID { get; set; }
        public int bookingEmployeeNoID { get; set; }
        public virtual Location locationNo { get; set; }
        public virtual Course courseNo { get; set; }
        public virtual Employee bookingEmployeeNo { get; set; }
       
    }
}