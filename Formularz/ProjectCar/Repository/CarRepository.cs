using ProjectCar.Models;
using ProjectCar.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectCar.Repository
{
    public class CarRepository : AbstractRepository<CarEntity>, ICarRepository 
    {
    }
}