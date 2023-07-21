

using Banking.Domain;

namespace Banking.UnitTests.BonusCalculator;

public class BonusCalculatorTests
{
    [Theory]
    [InlineData(100,10)]
    [InlineData(200, 20)]
    public void HasSufficientBalance(decimal amountOfDeposit, decimal expectedBonus)
    {

        var duringBusinessHourClock = new Mock<IProvideTheBusinessClock>();
        duringBusinessHourClock.Setup(c => c.IsDuringBusinessHours()).Returns(true);
        var bonusCalculator = new StandardBonusCalculator(duringBusinessHourClock.Object);
        var balanceOnAccount = 5000M;


        decimal bonus = bonusCalculator.CalculateBonusForDeposit(balanceOnAccount, amountOfDeposit);

        Assert.Equal(expectedBonus,bonus);
    }
    [Theory]
    [InlineData(100, 0)]
    [InlineData(200, 0)]
    public void HasInsufficientBalance(decimal amountOfDeposit, decimal expectedBonus)
    {
        var duringBusinessHourClock = new Mock<IProvideTheBusinessClock>();
        duringBusinessHourClock.Setup(c => c.IsDuringBusinessHours()).Returns(true);
        var bonusCalculator = new StandardBonusCalculator(duringBusinessHourClock.Object);
        var balanceOnAccount = 4999.9M;


        decimal bonus = bonusCalculator.CalculateBonusForDeposit(balanceOnAccount, amountOfDeposit);

        Assert.Equal(expectedBonus, bonus);
    }

    [Fact]
    public void BonusIsFullIfDuringBusinessHours()
    {

    }
    [Fact]
    public void BonusIsHalfOutsideBusinessHours()
    {
        var duringBusinessHourClock = new Mock<IProvideTheBusinessClock>();
        duringBusinessHourClock.Setup(c => c.IsDuringBusinessHours()).Returns(false);
        var bonusCalculator = new StandardBonusCalculator(duringBusinessHourClock.Object);
        var bonus = bonusCalculator.CalculateBonusForDeposit(6000, 100);

        Assert.Equal(5M, bonus);

    }
}
