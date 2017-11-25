using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Samochody.Models
{
    public class CarDBContext : DbContext
    {
        public CarDBContext() : base("CarInfo")
        {

        }

        public DbSet<CarModel> CarInfos { get; set; }
    }
}