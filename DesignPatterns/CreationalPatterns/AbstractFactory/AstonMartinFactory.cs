using DesignPatterns.CreationalPatterns.Entities;
using System;

namespace DesignPatterns.CreationalPatterns.AbstractFactory
{
    public class AstonMartinFactory : ICarFactory
    {
        public ICar Create()
        {
            return new AstonMartin();
        }
    }
}