using NUnit.Framework;

namespace TestApp.UnitTests;

public class PrimeFactorTests
{
    [Test]
    public void Test_FindLargestPrimeFactor_PrimeNumber()
    {
        long input = 11;
        long expected = 11;
        
        long result = PrimeFactor.FindLargestPrimeFactor(input);
        
        Assert.That(result, Is.EqualTo(expected));
    }
    
    [Test]
    public void Test_FindLargestPrimeFactor_LargeNumber()
    {
        long input = 84;
        long expected = 7;
        
        long result = PrimeFactor.FindLargestPrimeFactor(input);
        
        Assert.That(result, Is.EqualTo(expected));
    }
}
