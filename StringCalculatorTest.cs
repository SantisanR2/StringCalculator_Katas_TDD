using AwesomeAssertions;

namespace StringCalculator;

public class StringCalculatorTest
{
    [Fact]
    public void Test1()
    {
        //Arrange
        var stringInteger = "5";

        //Act
        var result = calculate(stringInteger);

        //Assert
        result.Should().Be(5);

    }

    private int calculate(string stringInteger)
    {
        return 5;
    }
}