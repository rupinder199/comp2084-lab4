using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace RogersMobile.Models
{
    public class DataContext : DbContext
    {
        public DbSet<Phone> Phone { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }

    }
}