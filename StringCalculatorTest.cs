using AwesomeAssertions;

namespace StringCalculator;

public class StringCalculatorTest
{
    [Fact]
    public void Debe_Dar_El_Mismo_Numero_Si_Solo_Se_Manda_Uno()
    {
        //Arrange
        var stringInteger = "5";

        //Act
        var result = calculate(stringInteger);

        //Assert
        result.Should().Be(5);

    }

    [Fact]
    public void test()
    {
        //Arrange
        var operation = "2+6";
        
        //Act
        var result = calculate(operation);
        
        //Assert
        result.Should().Be(8);
        
    }

    private int calculate(string operation)
    {
        return 5;
    }
}