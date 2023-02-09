namespace Banking.UnitTests;

public class GoldCustomerGetBonusDeposits
{

    [Fact]
    public void BonusAppliedToDeposit()
    {
        var account = new BankAccount();
        var openingBalance = account.GetBalance();
        var amountToDeposit = 100M;

        account.Deposit(amountToDeposit);

        Assert.Equal(openingBalance + amountToDeposit + 10M, account.GetBalance());
    }
}
