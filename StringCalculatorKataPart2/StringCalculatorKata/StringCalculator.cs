
namespace StringCalculatorKata;

public class StringCalculator
{
    private readonly ILogger _logger;
    private readonly IWebService _webService;

    public StringCalculator(ILogger logger, IWebService webService)
    {
        _logger = logger;
        _webService = webService;
    }


    public int Add(string numbers)
    {
        int result = 0;
        if (numbers != "")
        {
            result =  numbers.Split(',')
                .Select(int.Parse).Sum();
        }
        try
        {
            _logger.Log(result.ToString());
        }
        catch (CalculatorLoggerException)
        {
            //Call the web service
            _webService.NotifyOfLoggerFailure("BLAMMO!");
        }
        return result;
    }

}


public interface IWebService
{ 
    void NotifyOfLoggerFailure(string message); 
}

public class Logger : ILogger
{
    public void Log(string message)
    {
        //your specific logging thing here
        Console.WriteLine(message);
    }
}

