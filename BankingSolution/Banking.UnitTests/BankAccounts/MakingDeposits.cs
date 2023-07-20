
using Banking.Domain;

namespace Banking.UnitTests.BankAccounts;

public class MakingDeposits
{

    [Fact]
    public void DepositsIncreaseTheBalance()
    {
        //Given
        var account = new BankAccount();
        var openingBalance = account.GetBalance();
        decimal amountToDeposit = 100.25M;

        //When
        account.Deposit(amountToDeposit);
        //Then
        Assert.Equal(amountToDeposit + openingBalance, account.GetBalance());  

    }

    

    [Fact(Skip = "just a demo")]
    public void Demo()
    {
        var jcAccount = new BankAccount();
        var joeyAccount = new BankAccount();

        jcAccount.Deposit(100);

        Assert.Equal(5100, jcAccount.GetBalance());

        Assert.Equal(5000, joeyAccount.GetBalance());  
    }
}
