using DesignPatterns.StructuralPatterns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace UnitTests.DesignPatterns.StructuralPatterns
{
    public class AdapterTests
    {
        [Fact]
        public void WhenInvoke_Adapt_ShouldInvokeAdaptee()
        {            
            //arrange
            var adaptee = new Adaptee();
            var sut = new Adapter(adaptee);
            //act
            sut.Adapt();
            //assert
            Assert.Equal(1, adaptee.GetInvokedCount());
        }
    }
}
