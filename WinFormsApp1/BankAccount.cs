namespace WinFormsApp1;

public class BankAccount
{
    public string Owner { get; set; }
    public Guid BankAccountNumber { get; set; }
    public decimal Balance { get; protected set; }
    
    public BankAccount(string owner)
    {
        Owner = owner;
        BankAccountNumber = Guid.NewGuid();
        Balance = 0;
    }

    public virtual string Deposit(decimal amount)
    {
        if (amount <= 0)
            return $"You can't deposit ${amount}.";        

        if (amount > 20000)
            return "AML deposit limit of $20,000 reached.";

        Balance += amount;
        return $"Successfully deposited into your account.";
    }

    public string Withdraw(decimal amount)
    {
        if (amount <= 0)
            return $"You can't withdraw {amount}";

        if (amount > Balance)
            return $"You only have ${Balance} available.";

        Balance -= amount;
            return $"Successfully withdrawn. Your new balance is ${Balance}.";
    }
}