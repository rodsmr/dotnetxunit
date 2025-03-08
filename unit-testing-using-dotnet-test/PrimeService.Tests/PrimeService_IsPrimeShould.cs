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

    [Fact]
    public void IsPrime_IsInput4_ReturnFalse()
    {
        // Arrange: skip
        
        // Act
        var result = _primeService.IsPrime(4);
        
        // Assert
        Assert.False(result, $"4 should NOT be prime");
    }
    
    // Add more tests for prime numbers using Theory
    [Theory]
    [InlineData(2)]
    [InlineData(3)]
    [InlineData(5)]
    [InlineData(7)]
    public void IsPrime_InputLessThan10_ReturnTrue(int number)
    {
        // Arrange: skip
        
        // Act
        bool result = _primeService.IsPrime(number);
        
        // Assert
        Assert.True(result, $"{number} should be prime");
    }
    
    [Theory]
    [InlineData(4)]
    [InlineData(6)]
    [InlineData(8)]
    [InlineData(9)]
    public void IsPrime_InputLessThan10_ReturnFalse(int number)
    {
        // Arrange: skip
        
        // Act
        bool result = _primeService.IsPrime(number);
        
        // Assert
        Assert.False(result, $"{number} should NOT be prime");
    }
    
    [Theory]
    [InlineData(11)]
    [InlineData(13)]
    [InlineData(17)]
    [InlineData(19)]
    public void IsPrime_InputGreatherThan10_ReturnTrue(int number)
    {
        // Arrange: skip
        
        // Act
        bool result = _primeService.IsPrime(number);
        
        // Assert
        Assert.True(result, $"{number} should be prime");
    }
    
    [Theory]
    [InlineData(12)]
    [InlineData(14)]
    [InlineData(15)]
    [InlineData(16)]
    [InlineData(18)]
    public void IsPrime_InputGreatherThan10_ReturnFalse(int number)
    {
        // Arrange: skip
        
        // Act
        bool result = _primeService.IsPrime(number);
        
        // Assert
        Assert.False(result, $"{number} should be prime");
    }
}