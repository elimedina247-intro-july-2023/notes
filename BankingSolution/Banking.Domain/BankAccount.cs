namespace Banking.Domain;

public class BankAccount
{
    private decimal _balance = 5000M;


    public void Deposit(decimal amountToDeposit)
    {
        GuardCorrectTransactionAmount(amountToDeposit);
        _balance += amountToDeposit;
        
        
    }
    public void Withdraw(decimal amountToWithdraw)
    {
        GuardCorrectTransactionAmount(amountToWithdraw);
        GuardHasSufficientBalance(amountToWithdraw);
        _balance -= amountToWithdraw;
    }

    private void GuardHasSufficientBalance(decimal amountToWithdraw)
    {
        if (amountToWithdraw > _balance)
        {
            throw new AccountOverdraftException();
        }
    }

    private void GuardCorrectTransactionAmount(decimal amountToWithdraw)
    {
        if (amountToWithdraw <= 0)
        {
            throw new InvalidBankAccountTransactionAmountException();
        }
    }

    public decimal GetBalance()
    {
        
        return _balance;
    }
}
