namespace WinFormsApp1;

public class BankAccount
{
    public string Owner { get; set; }
    public Guid BankAccountNumber { get; set; }
    public decimal Balance { get; set; }

    public void CreateBankAccount()
    {
        
    }

    public void Deposit(decimal amount, string owner, string bankAccountNumber)
    {
        
    }

    public void Withdraw(decimal amount, string owner, string bankAccountNumber)
    {
        
    }
    
    public BankAccount(string owner)
    {
        Owner = owner;
        BankAccountNumber = Guid.NewGuid();
        Balance = 0;
    }
}