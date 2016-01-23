using System;

namespace DesignPatterns.CreationalPatterns
{
    public class BentleyFactory : ICarFactory
    {
        public ICar Create()
        {
            return new Bentley();
        }
    }
}