using NUnit.Framework;

namespace TestApp.UnitTests;

public class FibonacciTests
{
    [Test]
    public void Test_CalculateFibonacci_ZeroInput()
    {
        // Arrange
        int input = 0;
        int expected = 0;
        
        // Act
        int result  = Fibonacci.CalculateFibonacci(input);
        
        //Assert
        Assert.That(result, Is.EqualTo(expected));
        
    }

    [Test]
    public void Test_CalculateFibonacci_PositiveInput()
    {
        int  input = 5;
        int expected = 5;
        
        int result  = Fibonacci.CalculateFibonacci(input);
        
        Assert.That(result, Is.EqualTo(expected));
    }
}
