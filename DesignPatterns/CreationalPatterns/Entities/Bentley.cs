using System;

namespace DesignPatterns.CreationalPatterns.Entities
{
    public class Bentley : ICar
    {
        public string Color { get; set; }
        public bool IsDriving { get; private set;}
        public int Wheel { get; set; }

        public void Drive()
        {
            IsDriving = true;
            Console.WriteLine("Bentley");
        }

        public void StopDrive()
        {
            IsDriving = false;
        }
    }
}