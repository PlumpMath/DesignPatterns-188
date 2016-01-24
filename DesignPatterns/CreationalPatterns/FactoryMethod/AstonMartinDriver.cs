using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.CreationalPatterns.Entities;

namespace DesignPatterns.CreationalPatterns.FactoryMethod
{
    public class AstonMartinDriver : DriverBase
    {
        protected override ICar CreateCar()
        {
            return new AstonMartin();
        }
    }
}
