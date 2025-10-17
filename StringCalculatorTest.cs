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

    [Theory]
    [InlineData("8-6", 2)]
    [InlineData("60-25", 35)]
    [InlineData("300-60", 240)]
    [InlineData("84-62", 22)]
    public void Debe_Restar_Si_Dos_Enteros_Separados_Por_Menos(string operation, int expectedResult)
    {
        //Arrange

        //Act
        var result = Calculate(operation);
        
        //Assert
        result.Should().Be(expectedResult);
    }
    
    [Fact]
    public void Debe_Ignorarse_Los_Espacios_En_Blanco()
    {
        //Arrange
        var operation = " 5 0+ 35";
        
        //Act
        var result = Calculate(operation);
        
        //Assert
        result.Should().Be(85);
    }

    [Theory]
    [InlineData("50-25", 25)]
    [InlineData("-15+6", -9)]
    [InlineData("200-150", 50)]
    [InlineData("-200-150", -350)]
    public void Debe_Calcular_Correctamente(string operation, int expectedResult)
    {
        //Arrange
        
        //Act
        var  result = Calculate(operation);
        
        //Assert
        result.Should().Be(expectedResult);
    }

    private int Calculate(string operation)
    {
        operation = operation.Replace(" ", "");

        for (int i = 1; i < operation.Length; i++)
        {
            if (operation[i] == '+')
            {
                return int.Parse(operation.Substring(0, i)) + int.Parse(operation.Substring(i + 1));
            }
            if (operation[i] == '-')
            {
                return int.Parse(operation.Substring(0, i)) - int.Parse(operation.Substring(i + 1));
            }
        }

        return int.Parse(operation);
    }
}