using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FooBarQix.Tests
{
    public class FooBarQix_Step1
    {
        [Theory]
        [InlineData(3)]
        [InlineData(6)]
        [InlineData(9)]
        public void FooBarQix_IsDivisibleBy3_ShouldBeFoo(int number)
        {
            // Arrange
            FooBarQix fooBarQix = new FooBarQix();

            // Act
            var result = fooBarQix.Compute(number.ToString());

            // Assert
            Assert.Equal("Foo", result);
        }

        [Theory]
        [InlineData(13)]
        [InlineData(1)]
        [InlineData(4)]
        public void FooBarQix_NotIsDivisibleBy3_ShouldBeNumber(int number)
        {
            // Arrange
            FooBarQix fooBarQix = new FooBarQix();

            // Act
            var result = fooBarQix.Compute(number.ToString());

            // Assert
            Assert.Equal(number.ToString(), result);
        }

        [Fact]
        public void FooBarQix_IsDivisibleBy5_ShouldBeBar()
        {
            // Arrange
            FooBarQix fooBarQix = new();

            // Act
            var result = fooBarQix.Compute("20");

            // Assert
            Assert.Equal("Bar", result);
        }


        [Theory]
        [InlineData(15)]
        [InlineData(45)]
        [InlineData(60)]
        public void FooBarQix_IsDivisibleBy3And5_ShouldBeFooBar(int number)
        {
            // Arrange
            FooBarQix fooBarQix = new();

            // Act
            var result = fooBarQix.Compute(number.ToString());

            // Assert
            Assert.Equal("FooBar", result);
        }
    }
}