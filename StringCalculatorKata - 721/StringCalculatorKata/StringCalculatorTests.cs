﻿
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


}
