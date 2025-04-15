namespace FooBarQix.Tests
{
    public class FooBarQix_Step1
    {
        [Theory]
        [InlineData(3)]
        [InlineData(6)]
        [InlineData(1)]
        public void FooBarQix_IsDivisibleBy3_ShouldBeFoo(int number)
        {
            // Arrange
            FooBarQix fooBarQix = new FooBarQix();

            // Act
            var result = fooBarQix.Compute(number.ToString());

            // Assert
            Assert.Equal("Foo", result);
        }
    }
}