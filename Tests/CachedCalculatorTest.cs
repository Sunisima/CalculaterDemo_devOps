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
    public void Use_Cache_when_add_is_called_twice_with_same_values()
    {
        // Arrange
        var calc = new CachedCalculator();
        calc.Add(2, 3);
        calc.Add(2, 3);

        // Act & Assert
        Assert.That(calc._cache.Count, Is.EqualTo(1));
    }

    [Test]
    public void Subtract()
    {
        //Arrange
        var calc = new CachedCalculator();
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
        var calc = new CachedCalculator();
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
    public void Use_Cache_when_Factorial_is_called_twice_with_same_values()
    {
        // Arrange
        var calc = new CachedCalculator();
        calc.Factorial(6);
        calc.Factorial(6);

        // Act & Assert
        Assert.That(calc._cache.Count, Is.EqualTo(1));
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
    
    [Test]
    public void Use_Cache_when_IsPrime_is_called_twice_with_same_values()
    {
        // Arrange
        var calc = new CachedCalculator();
        calc.IsPrime(8);
        calc.IsPrime(8);

        // Act & Assert
        Assert.That(calc._cache.Count, Is.EqualTo(1));
    }

    [Test]
    public void Calculation_with_different_inputValues_should_create_two_entries()
    {
        //Arrange
        var calc = new CachedCalculator();
        calc.Add(3, 5);
        calc.Add(111, 6);
        
        //Act & Assert
        Assert.That(calc._cache.Count, Is.EqualTo(2));
    }
}