using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MvcApplicationRUTH.Models
{
    public class Invoice
    {
        [Key]
        public int invoiceNoID { get; set; }
        public DateTime dateRaised { get; set; }
        public DateTime datePaid { get; set; }
        public string creditCardNo { get; set; }
        public string holdersName { get; set; }
        public DateTime expiryDate { get; set; }
        public int registrationNoID { get; set; }
        public int pMethodNoID { get; set; }
        public virtual Registrations registrationNo { get; set; }
        public virtual PaymentMethod pMethodNo { get; set; }
    }
}