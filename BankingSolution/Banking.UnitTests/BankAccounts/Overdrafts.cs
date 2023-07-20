
namespace Banking.UnitTests.BankAccounts;

public class Overdrafts
{
    [Fact]
    public void DoesNotDecreaseTheBalanceAndThrowsException()
    {
        var account = new BankAccount();
        var openingBalance = account.GetBalance();
        var amountToWithdraw = openingBalance + .01M;
        
        Assert.Throws<AccountOverdraftException>(() =>
        {
            account.Withdraw(amountToWithdraw);
        });
        Assert.Equal(openingBalance, account.GetBalance());

    }
}
