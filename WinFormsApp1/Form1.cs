namespace WinFormsApp1;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        
        BankAccount bankAccount = new BankAccount
        {
            Balance = 1000,
            BankAccountNumber = Guid.NewGuid(),
            Owner = "John Doe"
        };
        
        BankAccount bankAccount2 = new BankAccount
        {
            Balance = 10000,
            BankAccountNumber = Guid.NewGuid(),
            Owner = "Jane Doe"
        };
        
        BankAccount bankAccount3 = new BankAccount
        {
            Balance = 10000000,
            BankAccountNumber = Guid.NewGuid(),
            Owner = "Bill Gates"
        };
        
        List<BankAccount> bankAccounts = [bankAccount, bankAccount2, bankAccount3];
        
        BankAccountsGrid.DataSource = bankAccounts;
    }
}