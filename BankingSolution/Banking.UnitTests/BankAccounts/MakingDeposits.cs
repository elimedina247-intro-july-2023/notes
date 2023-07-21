
using Banking.Domain;

namespace Banking.UnitTests.BankAccounts;

public class MakingDeposits
{

    [Fact]
    public void DepositsIncreaseTheBalance()
    {
        //Given
        var account = new BankAccount(new Mock<ICanCalculateBonusesForBankAccountDeposits>().Object);
        var openingBalance = account.GetBalance();
        decimal amountToDeposit = 100.25M;

        //When
        account.Deposit(amountToDeposit);
        //Then
        Assert.Equal(amountToDeposit + openingBalance, account.GetBalance());  

    }

    

}

public class DummyBonusCalculator : ICanCalculateBonusesForBankAccountDeposits
{
    public decimal CalculateBonusForDeposit(decimal balance, decimal amountToDeposit)
    {
        return 0;
    }
}
