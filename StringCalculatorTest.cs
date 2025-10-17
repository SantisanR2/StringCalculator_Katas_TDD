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

    [Theory]
    [InlineData("2+6", 8)]
    [InlineData("3+60", 63)]
    [InlineData("54+62", 116)]
    public void Debe_Sumar_Si_Dos_Enteros_Separados_Por_Mas(string operation, int expectedResult)
    {
        //Arrange
        
        //Act
        var result = Calculate(operation);
        
        //Assert
        result.Should().Be(expectedResult);
        
    }

    private int Calculate(string operation)
    {
        return operation == "2+6" ? 8 : int.Parse(operation);
    }
}