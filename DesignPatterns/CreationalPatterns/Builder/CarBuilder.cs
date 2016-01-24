using DesignPatterns.CreationalPatterns.Entities;
using System;

namespace DesignPatterns.CreationalPatterns.Builder
{
    public class CarBuilder
    {
        private int _wheelSize;
        private string _color;

        public CarBuilder()
        {
            _wheelSize = 0;
            _color = "blue";
        }

        public CarBuilder WithWheelSize(int size)
        {
            _wheelSize = size;
            return this;
        }

        public CarBuilder WithColor(string color)
        {
            _color = color;
            return this;
        }

        public ICar Build()
        {
            ICar car = new AstonMartin();
            car.Color = _color;
            car.Wheel = _wheelSize;
            return car;
        }
    }
}