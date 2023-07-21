
namespace StringCalculatorKata;

public class StringCalculatorTests
{
    private readonly StringCalculator _calculator;

    public StringCalculatorTests()
    {
        _calculator = new StringCalculator(new Mock<ILogger>().Object, new Mock<IWebService>().Object);
    }

    [Fact]
    public void EmptyStringReturnsZero()
    {
        

        //When
        var result = _calculator.Add("");
        //Then

        Assert.Equal(0, result);
    }
    //Skip Everything and just aritrary number
    [Theory]
    [InlineData("1,2,3,4,5,6,7,8,9", 45)]

    public void CommaSeparatedNumbers(string numbers, int expected)
    {
        
        var result = _calculator.Add(numbers);

        Assert.Equal(expected, result);
    }


}
