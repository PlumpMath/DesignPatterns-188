using DesignPatterns.CreationalPatterns.Entities;
using DesignPatterns.CreationalPatterns.FactoryMethod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace UnitTests.DesignPatterns.CreationalPatterns
{
    public class FactoryMethodTests
    {
        [Fact]
        public void WhenInvokeDirve_WithBentelyDriver_ShouldCreateBentelyAndSetIsDrivingToTrue()
        {
            //arrange
            var sut = new BentelyDriver();           
            //act
            sut.Drive();
            //assert
            Assert.True(sut.Car.IsDriving);
            Assert.IsType<Bentley>(sut.Car);
        }

        [Fact]
        public void WhenInvokeDirve_WithAstonMartinDriver_ShouldCreateAstonMartinyAndSetIsDrivingToTrue()
        {
            //arrange
            var sut = new AstonMartinDriver();
            //act
            sut.Drive();
            //assert
            Assert.True(sut.Car.IsDriving);
            Assert.IsType<AstonMartin>(sut.Car);
        }
    }
}
