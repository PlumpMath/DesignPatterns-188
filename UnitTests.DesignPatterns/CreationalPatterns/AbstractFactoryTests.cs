using DesignPatterns.CreationalPatterns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace UnitTests.DesignPatterns.CreationalPatterns
{
    public class AbstractFactoryTests
    {
        [Fact]
        public void WhenCreateCar_WithAstonMartinFactory_ShouldReturnAstonMartin()
        {
            //arrange
            ICarFactory sut = new AstonMartinFactory();
            //act
            ICar car = sut.Create();
            //assert
            Assert.IsType<AstonMartin>(car);
        }

        [Fact]
        public void WhenCreateCar_WithBentleyFactory_ShouldReturnBentley()
        {
            //arrange
            ICarFactory sut = new BentleyFactory();
            //act
            ICar car = sut.Create();
            //assert
            Assert.IsType<Bentley>(car);
        }
    }
}
