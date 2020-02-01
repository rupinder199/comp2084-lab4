using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace RogersMobile.Models
{
    public class Phone
    {
        public Phone()
        {
            PhoneName = "";
            DateReleased = DateTime.Now;
        }

        [Key]
        public int PhoneID { get; set; }

        [ForeignKey("Manufacturer")]
        public int ManufacturerID { get; set; }
        public string PhoneName { get; set; }

        public virtual Manufacturer Manufacturer { get; set; }

        public int MSRP { get; set; }

        public DateTime DateReleased { get; set; }
    }
}