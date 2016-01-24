using System.Collections.Generic;

namespace DesignPatterns.CreationalPatterns.Entities
{
    public interface ICar
    {
        string Color { get; set; }
        int Wheel { get; set; }

        void Drive();
    }
}