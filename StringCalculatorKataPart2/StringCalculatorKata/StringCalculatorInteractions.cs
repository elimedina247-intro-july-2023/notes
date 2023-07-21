using Castle.Core.Logging;
using System.Security.Cryptography.X509Certificates;

namespace StringCalculatorKata;

public class StringCalculatorInteractions
{
    [Theory]
    [InlineData("15","15")]
    [InlineData("1,2", "3")]
    public void ResultsAreLogged(string numbers, string expectedToBeLogged)
    {
        var loggerMock = new Mock<ILogger>();
        var webServiceStub = new Mock<IWebService>();
        var calculator = new StringCalculator(loggerMock.Object, webServiceStub.Object);

        calculator.Add(numbers);

        //then
        //Hey logger did you get called with "15"?
     
        loggerMock.Verify(Logger => Logger.Log(expectedToBeLogged));


        
    }
    [Fact]
    public void WebServiceIsCalledOnLoggerFailure()
    {
        var loggerStub = new Mock<ILogger>();
        var webServiceStub = new Mock<IWebService>();
        var calculator = new StringCalculator(loggerStub.Object,webServiceStub.Object);


        loggerStub.Setup(m => m.Log(It.IsAny<string>()))
            .Throws<CalculatorLoggerException>();

        calculator.Add("1");

        webServiceStub.Verify(m => m.NotifyOfLoggerFailure("BLAMMO!"));
    }

}
