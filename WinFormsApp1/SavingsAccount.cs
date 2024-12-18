using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class SavingsAccount : BankAccount
    {
        public decimal InterestRate { get; set; }
        public SavingsAccount(string owner, decimal interestRate):base($"{owner} ({interestRate}%)")
        {
            // child class should only initialize it's own properties
            InterestRate = interestRate;
        }


        public override string Deposit(decimal amount)
        {
            if (amount <= 0)
                return $"You can't deposit ${amount}.";

            if (amount > 20000)
                return "AML deposit limit of $20,000 reached.";
            decimal interestAmount = (InterestRate / 100) * amount;
            Balance += amount + interestAmount;
            return $"${amount} successfully deposited into your account.";
        }
    }
}
