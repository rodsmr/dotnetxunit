namespace FooBarQix.Tests
{
    public class FooBarQix_Step1
    {
        [Fact]
        public void FooBarQix_IsDivisibleBy3_ShouldBeFoo()
        {
            // Arrange
            FooBarQix fooBarQix = new FooBarQix();

            // Act
            var result = fooBarQix.Compute("3");

            // Assert
            Assert.Equal("Foo", result);
        }
    }
}