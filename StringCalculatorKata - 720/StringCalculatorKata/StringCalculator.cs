
namespace StringCalculatorKata;

public class StringCalculator
{

    public int Add(string numbers)
    {
        if(numbers == "")
        {
            return 0;
        }
        if (numbers.Length == 1)
        {
            return int.Parse(numbers);
        }
        var digits = numbers.Split(',');
        return int.Parse(digits[0]) + int.Parse(digits[1]);


       
    }

}

