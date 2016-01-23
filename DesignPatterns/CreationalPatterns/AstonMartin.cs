﻿using System;

namespace DesignPatterns.CreationalPatterns
{
    public class AstonMartin : ICar
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
            Console.WriteLine("Aston martin drive");
        }
    }
}