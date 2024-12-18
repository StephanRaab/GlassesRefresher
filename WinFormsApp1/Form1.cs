namespace WinFormsApp1;

public partial class Form1 : Form
{
    List<BankAccount> BankAccounts = new List<BankAccount>();

    public Form1()
    {
        InitializeComponent();
    }

    private void CreateAccountBtn_Click(object sender, EventArgs e)
    {
        BankAccount bankAccount = new BankAccount(OwnerInput.Text);
        BankAccounts.Add(bankAccount);

        RefreshGrid();
    }

    private void DepositBtn_Click(object sender, EventArgs e)
    {

    }

    private void WithdrawBtn_Click(object sender, EventArgs e)
    {

    }

    private void RefreshGrid()
    {
        BankAccountsGrid.DataSource = null;
        BankAccountsGrid.DataSource = BankAccounts;
    }
}