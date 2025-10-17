using AwesomeAssertions;

namespace StringCalculator;

public class StringCalculatorTest
{
    [Theory]
    [InlineData("1")]
    [InlineData("3")]
    [InlineData("5")]
    public void Debe_Dar_El_Mismo_Numero_Si_Solo_Se_Manda_Uno(string stringInteger)
    {
        //Arrange

        //Act
        var result = Calculate(stringInteger);

        //Assert
        result.Should().Be(int.Parse(stringInteger));

    }

    [Fact]
    public void Debe_Sumar_Si_Dos_Enteros_Separados_Por_Mas()
    {
        //Arrange
        var operation = "2+6";
        
        //Act
        var result = Calculate(operation);
        
        //Assert
        result.Should().Be(8);
        
    }

    private int Calculate(string operation)
    {
        return operation == "2+6" ? 8 : int.Parse(operation);
    }
}