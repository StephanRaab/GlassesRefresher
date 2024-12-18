namespace WinFormsApp1;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();

        BankAccount bankAccount = new BankAccount("Jeffrei Besos");
        BankAccount bankAccount2 = new BankAccount("Marky Zucker");
        BankAccount bankAccount3 = new BankAccount("Billiam Gates");
        
        List<BankAccount> bankAccounts = [bankAccount, bankAccount2, bankAccount3];
        
        BankAccountsGrid.DataSource = bankAccounts;
    }
}