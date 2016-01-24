using DesignPatterns.CreationalPatterns.Builder;
using DesignPatterns.CreationalPatterns.Entities;
using Xunit;

namespace UnitTests.DesignPatterns.CreationalPatterns
{
    public class BuilderTests
    {
        [Theory]
        [InlineData(1, "blue")]
        [InlineData(2, "black")]
        [InlineData(3, "pink")]
        public void WhenBuild_WithSizeAndColor_ShouldReturnCarWithSizeAndColor(int size, string color)
        {
            //act
            ICar car = new CarBuilder()
                                .WithWheelSize(size)
                                .WithColor(color)
                                .Build();

            //assert
            Assert.Equal(size, car.Wheel);
            Assert.Equal(color, car.Color);
        }
    }
}
