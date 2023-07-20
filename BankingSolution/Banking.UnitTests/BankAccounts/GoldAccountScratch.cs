
namespace Banking.UnitTests.BankAccounts;

public class GoldAccountScratch
{

    [Fact]
    public void GoldAccountsGetBonusOnDeposit()
    {
        var account = new BankAccount();
        var openingBalance = account.GetBalance();
        var amountToDeposit = 100M;


        //Hey you do this thing. (Command, Func)
        account.Deposit(amountToDeposit); 


        //Hey you, tell me something
        var balance = account.GetBalance();

        Assert.Equal(amountToDeposit + 10M + openingBalance, account.GetBalance());
    }
}
