using NUnit.Framework;

namespace TestApp.UnitTests;

public class EmailTests
{
    [Test]
    public void Test_IsValidEmail_ValidEmail()
    {
        // Arrange
        string validEmail = "test@example.com";

        // Act
        var result = Email.IsValidEmail(validEmail);
        
        // Assert
        
        Assert.IsTrue(result);
    }

    [Test]
    public void Test_IsValidEmail_InvalidEmail()
    {
        var invalidMail = "test@";
        
        var  result = Email.IsValidEmail(invalidMail);
        
        Assert.IsFalse(result);
            
    }

    [Test]
    public void Test_IsValidEmail_NullInput()
    {
        
        var result = Email.IsValidEmail(null);
        
        Assert.IsFalse(result);
    }
}
