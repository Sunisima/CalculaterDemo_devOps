using Calculator;

namespace Tests;

public class CachedCalculatorTest
{
    [Test]
    public void Add()
    {
        // Arrange
        var calc = new CachedCalculator();
        var a = 2;
        var b = 3;

        // Act
        var result = calc.Add(a, b);

        // Assert
        Assert.That(result, Is.EqualTo(5));
    }
    
    [Test]
    public void Subtract()
    {
        //Arrange
        var calc = new SimpleCalculator();
        var a = 7;
        var b = 5;
        
        //Act
        var result = calc.Subtract(a, b);
        
        //Assert
        Assert.That(result, Is.EqualTo(2));
    }
    
    [Test]
    public void Multiply()
    {
        //Arrange
        var calc = new SimpleCalculator();
        var a = 55;
        var b = 50;
        
        //Act
        var result = calc.Multiply(a, b);
        
        //Assert
        Assert.That(result, Is.EqualTo(2750));
    }
    
    [Test]
    public void Divide()
    {
        //Arrange
        var calc = new CachedCalculator();
        var a = 500;
        var b = 2;
        
        //Act
        var result = calc.Divide(a, b);
        
        //Assert
        Assert.That(result, Is.EqualTo(250));
    }

    [Test]
    public void Factorial()
    {
        //Arrange
        var calc = new CachedCalculator();
        var n = 7;
        
        //Act
        var result = calc.Factorial(n);
        
        //Assert
        Assert.That(result, Is.EqualTo(5040));
    }
    
    [Test]
    public void IsPrime()
    {
        //Arrange
        var calc = new CachedCalculator();
        var candidate = 2;
        
        //Act
        var result = calc.IsPrime(candidate);
        
        //Assert
        Assert.That(result, Is.EqualTo(true));
    }
}