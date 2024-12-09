namespace console1;

public class BankAccount
{
    private decimal balance;

    public BankAccount(decimal balance)
    {
        Deposit(balance);
    }

    public void Deposit(decimal amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException("Deposit amount cannot be negative");
        }
        
        this.balance += amount;
    }

    public void Withdraw(decimal amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException("Withdraw amount cannot be negative");
        }

        if (amount > this.balance)
        {
            throw new InvalidOperationException("Insufficient balance");
        }
       
        this.balance -= amount;
    }
    
    public decimal GetBalance() => this.balance;
}