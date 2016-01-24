using DesignPatterns.CreationalPatterns.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.FactoryMethod
{
    public abstract class DriverBase
    {
        public ICar Car { get; private set; }

        public void Drive()
        {
            Car = CreateCar();
            Car.Drive();
        }

        protected abstract ICar CreateCar();       
    }
}
