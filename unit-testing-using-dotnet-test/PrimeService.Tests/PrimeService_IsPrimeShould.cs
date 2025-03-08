namespace PrimeService.Tests;

public class PrimeService_IsPrimeShould
{
    private readonly PrimeService _primeService = new();

    [Fact]
    public void IsPrime_InputIs1_ReturnFalse()
    {
        // Arrange: replaced by the constructor
        // var primeService = new PrimeService();
        
        // Act
        bool result = _primeService.IsPrime(1);
        
        // Assert
        Assert.False(result, "1 should not be prime");
    }
    
    // Bad practice create a new test if only a parameter is changed
    // [Fact]
    // public void IsPrime_InputIs0_ReturnFalse()
    // {
    //     // Arrange
    //     var primeService = new PrimeService();
    //     
    //     // Act
    //     bool result = primeService.IsPrime(0);
    //     
    //     // Assert
    //     Assert.False(result, "0 should not be prime");
    // }
    
    // Test for a prime number with input: -1, 0, 1
    // Use Theory insted of Fact
    [Theory]
    [InlineData(-1)]
    [InlineData(0)]
    [InlineData(1)]
    public void IsPrime_ValuesLessThan2_ReturnFalse(int value)
    {
        // Arrange: replaced by the constructor
        // var primeService = new PrimeService();
        
        // Act
        bool result = _primeService.IsPrime(value);
        
        // Assert
        Assert.False(result, $"{value} should not be prime");
    }
    
    [Fact]
    public void IsPrime_IsInput2_ReturnTrue()
    {
        // Arrange: replaced by the constructor
        // var primeService = new PrimeService();
        
        // Act
        bool result = _primeService.IsPrime(2);
        
        // Assert
        Assert.True(result, "2 should be prime");
    }

    [Fact]
    public void IsPrime_IsInput3_ReturnTrue()
    {
        // Arrange: skip
        
        // Act
        var result = _primeService.IsPrime(3);
        
        // Assert
        Assert.True(result, $"3 should be prime");
    }
}