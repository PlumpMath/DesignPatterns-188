using DesignPatterns.CreationalPatterns.Entities;
using System;

namespace DesignPatterns.CreationalPatterns.AbstractFactory
{
    public class BentleyFactory : ICarFactory
    {
        public ICar Create()
        {
            return new Bentley();
        }
    }
}