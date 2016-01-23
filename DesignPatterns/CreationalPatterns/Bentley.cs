using System;

namespace DesignPatterns.CreationalPatterns
{
    public class Bentley : ICar
    {
        public string Color
        {
            get;

            set;
        }

        public int Wheel
        {
            get;

            set;
        }

        public void Drive()
        {
            Console.WriteLine("Bentley Drive");
        }
    }
}