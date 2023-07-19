
namespace StringCalculatorKata;

public class StringCalculatorTests
{

    [Fact]
    public void EmptyStringReturnsZero()
    {
        //Given
        var calculator = new StringCalculator();

        //When
        var result = calculator.Add("");
        //Then

        Assert.Equal(0, result);
    }

    [Theory]
    [InlineData("1",1)]
    [InlineData("2",2)]
    [InlineData("108", 108)]
    public void SingleDigit(string numbers, int expected)
    {
        var calculator = new StringCalculator();
        var result = calculator.Add(numbers);

        Assert.Equal(expected, result);

    }
    [Theory]
    [InlineData("1,2",3)]
    [InlineData("10,2", 12)]
    [InlineData("108,200",308)]
    public void TwoDigits(string numbers, int expected)
    {
        var calculator = new StringCalculator();
        var result = calculator.Add(numbers);

        Assert.Equal(expected, result);
    }
    [Theory]
    [InlineData("1,2,3", 6)]
    public void ArbitraryNumbers(string numbers, int expected)
    {
        var calculator = new StringCalculator();
        var result = calculator.Add(numbers);

        Assert.Equal(expected, result);
    }


    [Theory(Skip = "Not Ready Yet")]
    [InlineData("1\n2\n3", 6)]
    [InlineData("1,2\n3", 6)]
    public void NewLineSeparators(string numbers, int expected)
    {
        var calculator = new StringCalculator();
        var result = calculator.Add(numbers);

        Assert.Equal(expected, result);
    }

    [Theory(Skip = "Not Ready Yet")]
    [InlineData("//X;\n1X2X3", 6)]

    public void CustomDelimeters(string numbers, int expected)
    {
        var calculator = new StringCalculator();
        var result = calculator.Add(numbers);

        Assert.Equal(expected, result);
    }

}
