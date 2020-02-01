using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace RogersMobile.Models
{
    public class Manufacturer
    {
        public Manufacturer()
        {
            ManufacturerName = "";
            URL = "";
            Founded = DateTime.Now;

        }

        public int ManufacturerID { get; set; }
        public string ManufacturerName { get; set; }
        public string URL { get; set; }
        public DateTime Founded { get; set; }

        public virtual ICollection<Phone> PhoneList { get; set; }
    }
}