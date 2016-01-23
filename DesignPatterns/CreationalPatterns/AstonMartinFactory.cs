using System;

namespace DesignPatterns.CreationalPatterns
{
    public class AstonMartinFactory : ICarFactory
    {
        public ICar Create()
        {
            return new AstonMartin();
        }
    }
}