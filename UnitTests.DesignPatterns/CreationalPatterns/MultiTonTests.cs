using DesignPatterns.CreationalPatterns.Multiton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace UnitTests.DesignPatterns.CreationalPatterns
{
    public class MultiTonTests
    {
        [Fact]
        public void WhenGetInstance_ShouldReturnInstanceNotNull()
        {
            //arrange act
            Multiton sut = Multiton.GetInstance("first");
            //assert
            Assert.NotNull(sut);
        }

        [Fact]
        public void WhenGetInstance_WithTheSameKey_ShouldReturnTheSameinstance()
        {
            //arrange act
            Multiton first = Multiton.GetInstance("first");
            Multiton sec = Multiton.GetInstance("first");
            //assert
            Assert.Equal(first, sec);
        }

        [Fact]
        public void WhenGetInstance_WithTheDiffrentKey_ShouldReturnTheDifferentinstances()
        {
            //arrange act
            Multiton first = Multiton.GetInstance("first");
            Multiton sec = Multiton.GetInstance("sec");
            //assert
            Assert.NotEqual(first, sec);
        }
    }
}
