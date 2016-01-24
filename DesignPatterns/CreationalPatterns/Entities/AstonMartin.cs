using System;

namespace DesignPatterns.CreationalPatterns.Entities
{
    public class AstonMartin : ICar
    {
        public string Color { get; set; }
        public bool IsDriving { get; private set; }
        public int Wheel { get; set; }

        public void Drive()
        {
            IsDriving = true;
            Console.WriteLine("Aston Martin");                
        }

        public void StopDrive()
        {
            IsDriving = false;
        }
    }
}