namespace WinFormsApp1;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        label1 = new Label();
        label2 = new Label();
        OwnerInput = new TextBox();
        AmountInput = new NumericUpDown();
        BankAccountsGrid = new DataGridView();
        DepositBtn = new Button();
        WithdrawBtn = new Button();
        CreateAccountBtn = new Button();
        InterestRateInput = new NumericUpDown();
        label3 = new Label();
        ((System.ComponentModel.ISupportInitialize)AmountInput).BeginInit();
        ((System.ComponentModel.ISupportInitialize)BankAccountsGrid).BeginInit();
        ((System.ComponentModel.ISupportInitialize)InterestRateInput).BeginInit();
        SuspendLayout();
        // 
        // label1
        // 
        label1.Font = new Font("Segoe UI", 12F);
        label1.Location = new Point(14, 23);
        label1.Name = "label1";
        label1.Size = new Size(84, 34);
        label1.TabIndex = 0;
        label1.Text = "Owner:";
        // 
        // label2
        // 
        label2.Font = new Font("Segoe UI", 12F);
        label2.Location = new Point(14, 395);
        label2.Name = "label2";
        label2.Size = new Size(96, 34);
        label2.TabIndex = 1;
        label2.Text = "Amount:";
        // 
        // OwnerInput
        // 
        OwnerInput.Location = new Point(97, 23);
        OwnerInput.Name = "OwnerInput";
        OwnerInput.Size = new Size(130, 23);
        OwnerInput.TabIndex = 2;
        // 
        // AmountInput
        // 
        AmountInput.Location = new Point(107, 395);
        AmountInput.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
        AmountInput.Name = "AmountInput";
        AmountInput.Size = new Size(120, 23);
        AmountInput.TabIndex = 3;
        // 
        // BankAccountsGrid
        // 
        BankAccountsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        BankAccountsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        BankAccountsGrid.Location = new Point(252, 23);
        BankAccountsGrid.Name = "BankAccountsGrid";
        BankAccountsGrid.Size = new Size(531, 336);
        BankAccountsGrid.TabIndex = 4;
        BankAccountsGrid.Text = "dataGridView1";
        // 
        // DepositBtn
        // 
        DepositBtn.Location = new Point(252, 378);
        DepositBtn.Name = "DepositBtn";
        DepositBtn.Size = new Size(257, 40);
        DepositBtn.TabIndex = 5;
        DepositBtn.Text = "Deposit";
        DepositBtn.UseVisualStyleBackColor = true;
        DepositBtn.Click += DepositBtn_Click;
        // 
        // WithdrawBtn
        // 
        WithdrawBtn.Location = new Point(515, 378);
        WithdrawBtn.Name = "WithdrawBtn";
        WithdrawBtn.Size = new Size(268, 40);
        WithdrawBtn.TabIndex = 6;
        WithdrawBtn.Text = "Withdraw";
        WithdrawBtn.UseVisualStyleBackColor = true;
        WithdrawBtn.Click += WithdrawBtn_Click;
        // 
        // CreateAccountBtn
        // 
        CreateAccountBtn.Location = new Point(97, 97);
        CreateAccountBtn.Name = "CreateAccountBtn";
        CreateAccountBtn.Size = new Size(130, 40);
        CreateAccountBtn.TabIndex = 7;
        CreateAccountBtn.Text = "Create Account\r\n";
        CreateAccountBtn.UseVisualStyleBackColor = true;
        CreateAccountBtn.Click += CreateAccountBtn_Click;
        // 
        // InterestRateInput
        // 
        InterestRateInput.DecimalPlaces = 2;
        InterestRateInput.Increment = new decimal(new int[] { 25, 0, 0, 131072 });
        InterestRateInput.Location = new Point(156, 57);
        InterestRateInput.Name = "InterestRateInput";
        InterestRateInput.Size = new Size(71, 23);
        InterestRateInput.TabIndex = 9;
        // 
        // label3
        // 
        label3.Font = new Font("Segoe UI", 12F);
        label3.Location = new Point(12, 57);
        label3.Name = "label3";
        label3.Size = new Size(176, 34);
        label3.TabIndex = 8;
        label3.Text = "Interest Rate (%):";
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(808, 465);
        Controls.Add(InterestRateInput);
        Controls.Add(label3);
        Controls.Add(CreateAccountBtn);
        Controls.Add(WithdrawBtn);
        Controls.Add(DepositBtn);
        Controls.Add(BankAccountsGrid);
        Controls.Add(AmountInput);
        Controls.Add(OwnerInput);
        Controls.Add(label2);
        Controls.Add(label1);
        Name = "Form1";
        Text = "Form1";
        ((System.ComponentModel.ISupportInitialize)AmountInput).EndInit();
        ((System.ComponentModel.ISupportInitialize)BankAccountsGrid).EndInit();
        ((System.ComponentModel.ISupportInitialize)InterestRateInput).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Button DepositBtn;
    private System.Windows.Forms.Button WithdrawBtn;
    private System.Windows.Forms.Button CreateAccountBtn;

    private System.Windows.Forms.DataGridView BankAccountsGrid;

    private System.Windows.Forms.NumericUpDown AmountInput;

    private System.Windows.Forms.TextBox OwnerInput;

    private System.Windows.Forms.Label label2;

    private System.Windows.Forms.Label label1;

    #endregion

    private NumericUpDown InterestRateInput;
    private Label label3;
}