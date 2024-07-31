using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace MvcApplicationRUTH.Models
{
    public class Delegate
    {
        [Key]
        public int delegateNoID { get; set; }

        [Required]
        public string delegateTitle { get; set; }
        [Required]
        public string delegateFName { get; set; }
        [Required]
        public string delegateLName { get; set; }
        [Required]
        public string delegateStreet { get; set; }
        [Required]
        public string delegateCity { get; set; }
        [Required]
        public string delegateState { get; set; }
        [Required]
        public string delegateZipCode { get; set; }
        [Required]
        public string attTelNo { get; set; }
        [Required]
        public string attFaxNo { get; set; }
        [Required]
        public string attEmailAddress { get; set; }
        public int clientNoID { get; set; }
        public virtual Client clientNo { get; set; }

    }
}