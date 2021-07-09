using System;
using System.Collections.Generic;
using System.Text;

namespace Banking
{
    class Savings: Account 
    {
        public decimal InterestRate { get; set; } = 0.12m;
        private static decimal MinBalance { get; set; } = 200m;

        public override void Withdraw(decimal Amount)
        {
            if(Balance- Amount < MinBalance)
            {
                throw new Exception($"Amount to withdraw must be <= {Balance - MinBalance}");
            }
            base.Withdraw(Amount);
        }

        public decimal CalculateInterest(int Months)
        {
            var interestAmount = Balance * (InterestRate / 12) * Months;
            Deposit(interestAmount);
            return interestAmount;
        }

       public static Savings OpenSavingsAccout(decimal OpenAmountDeposit)
        {
            if (OpenAmountDeposit < MinBalance)
            {
                throw new Exception($"Opening savings requires {MinBalance} deposit.");
            }
            var savings = new Savings();
            savings.Deposit(OpenAmountDeposit);
            return savings;
        }

        //Constructor that does not allow an empty deposit on savings
        private Savings() { }

        //Constructor that takes one peramiter
        public Savings(decimal OpenAmountDeposit) : base()
        {
            if (OpenAmountDeposit < MinBalance)
            {
                throw new Exception($"Opening savings requires {MinBalance} deposit.");
            }
            Deposit(OpenAmountDeposit);

        }

    }
}
