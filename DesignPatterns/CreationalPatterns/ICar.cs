using System.Collections.Generic;

namespace DesignPatterns.CreationalPatterns
{
    public interface ICar
    {
        string Color { get; set; }
        int Wheel { get; set; }

        void Drive();
    }
}