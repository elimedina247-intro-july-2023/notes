
namespace StringCalculatorKata;

public class StringCalculatorTests
{
    [Theory]
    [InlineData("1,2", 3)]
    public void TwoDigits(string numbers,int expected)
    {
        var calculator = new StringCalculator();
        var result = calculator.Add(numbers);

        Assert.Equal(expected, result);
    }
    [Fact]
    public void emptyStringReturnsZero()
    {

        var calculator = new StringCalculator();
        var result = calculator.Add("");

        Assert.Equal(0, result);   
    }
    [Theory]
    [InlineData("1",1)]
    public void SingleDigit(string numbers, int expected)
    {
        var calculator = new StringCalculator();
        var result = calculator.Add(numbers);

        Assert.Equal(expected, result);
    }
}
