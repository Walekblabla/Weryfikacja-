using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectCar.Models.ViewModels
{
    public class VMCars
    {
        public CarEntity Car { get; set; }
        public List<CarEntity> CarList { get; set; }

        public bool ShowIF { get; set; }
    }
}