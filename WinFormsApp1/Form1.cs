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
        if (string.IsNullOrEmpty(OwnerInput.Text))
            return;        

        if (InterestRateInput.Value > 0)
            BankAccounts.Add(new SavingsAccount(OwnerInput.Text, InterestRateInput.Value));
        else
            BankAccounts.Add(new BankAccount(OwnerInput.Text));
        
        RefreshGrid();
        OwnerInput.Text = string.Empty; // set input back to empty after adding owner
        OwnerInput.Focus(); // set focus back on the input
        InterestRateInput.Value = 0;
    }

    private void DepositBtn_Click(object sender, EventArgs e)
    {
        if (BankAccountsGrid.SelectedRows.Count == 1 && AmountInput.Value > 0)
        {
            BankAccount? selectedBankAccount = BankAccountsGrid.SelectedRows[0].DataBoundItem as BankAccount;
            string response = selectedBankAccount.Deposit(AmountInput.Value);

            RefreshGrid();
            AmountInput.Value = 0;

            MessageBox.Show(response);
        }
    }

    private void WithdrawBtn_Click(object sender, EventArgs e)
    {
        if (BankAccountsGrid.SelectedRows.Count == 1 && AmountInput.Value > 0)
        {
            BankAccount? selectedBankAccount = BankAccountsGrid.SelectedRows[0].DataBoundItem as BankAccount;
            string response = selectedBankAccount.Withdraw(AmountInput.Value);

            RefreshGrid();
            AmountInput.Value = 0;
            MessageBox.Show(response);
        }
    }

    private void RefreshGrid()
    {
        BankAccountsGrid.DataSource = null;
        BankAccountsGrid.DataSource = BankAccounts;
    }
}