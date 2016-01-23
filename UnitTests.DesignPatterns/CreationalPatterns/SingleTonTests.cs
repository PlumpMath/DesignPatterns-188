using DesignPatterns.CreationalPatterns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace UnitTests.DesignPatterns.CreationalPatterns
{
    public class SingleTonTests
    {
        [Fact]
        public void WhenGetInstance_ShouldReturnNotNullInstance()
        {
            //act
            SingleTon sut = SingleTon.Instance;
            //assert
            Assert.NotNull(sut);
        }

        [Fact]
        public void WhenGetInstance_Twice_ShouldBeEquals()
        {
            //act
            SingleTon sut1 = SingleTon.Instance;
            SingleTon sut2 = SingleTon.Instance;
            //assert
            Assert.Equal(sut1, sut2);
        }

        [Fact]
        public void ObjectConstactor_ShouldBePrivate()
        {
            //arrange
            Type singleTonType = typeof(SingleTon);
            //act
            var constractors = singleTonType.GetConstructors();
            //assert
            Assert.False(constractors.Any(x => x.IsPublic));
        }
    }
}
