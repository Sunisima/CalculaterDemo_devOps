using Calculator;

namespace Tests;

public class SimpleCalculatorTest
{
    [Test]
    public void Add()
    {
        // Arrange
        var calc = new SimpleCalculator();
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
}