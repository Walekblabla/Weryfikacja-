using ProjectCar.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectCar.BusinessLogic
{
    public class CarBusinessLogic : ICarBusinessLogic

    {
        public string CheckIf()
        {
            string name = "Niezalogowany";
            if (CheckIfUser())
                name = HttpContext.Current.User.Identity.Name;
            return name;
        }
        public bool CheckIfUser()
        {
            return HttpContext.Current.User.Identity.IsAuthenticated;

        }
    }
}