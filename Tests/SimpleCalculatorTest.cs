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
    
    [Test]
    public void Divide()
    {
        //Arrange
        var calc = new SimpleCalculator();
        var a = 500;
        var b = 2;
        
        //Act
        var result = calc.Divide(a, b);
        
        //Assert
        Assert.That(result, Is.EqualTo(250));
    }
    
    [Test]
    public void If_Factorial_Is_0_return1()
    {
        //Arrange
        var calc = new SimpleCalculator();
        var n = 0;
        
        //Act
        var result = calc.Factorial(n);
        
        //Assert
        Assert.That(result, Is.EqualTo(1));
    }

    [Test]
    public void If_Factorial_Is_minus2_return_Exception()
    {
        //Arrange
        var calc = new SimpleCalculator();
        
        //Act & Assert
        var exception = Assert.Throws<ArgumentException>(() => calc.Factorial(-2));
        Assert.That(exception!.Message, Is.EqualTo("Factorial is not defined for negative numbers"));
    }
    
    [Test]
    public void If_Factorial_Is_7_return5040()
    {
        //Arrange
        var calc = new SimpleCalculator();
        var n = 7;
        
        //Act
        var result = calc.Factorial(n);
        
        //Assert
        Assert.That(result, Is.EqualTo(5040));
    }
    
    [Test]
    public void IsPrime_7_return_true()
    {
        //Arrange
        var calc = new SimpleCalculator();
        var candidate = 7;
        
        //Act
        var result = calc.IsPrime(candidate);
        
        //Assert
        Assert.That(result, Is.EqualTo(true));
    }

    [Test]
    public void If_Prime_Under_2_return_False()
    {
        //Arrange
        var calc = new SimpleCalculator();
        var candidate = 1;
        
        //Act
        var result = calc.IsPrime(candidate);
        
        //Assert
        Assert.That(result, Is.EqualTo(false));
    }

    [Test]
    public void If_Not_Prime_return_false()
    {
        //Arrange
        var calc = new SimpleCalculator();
        var candidate = 9;
        
        //Act
        var result = calc.IsPrime(candidate);
        
        //Assert
        Assert.That(result, Is.EqualTo(false));
    }
    
    [Test]
    public void IsPrime_Even_Number_Greater_Than_2_Returns_False()
    {
        var calc = new SimpleCalculator();

        var result = calc.IsPrime(8);

        Assert.That(result, Is.False);
    }
}