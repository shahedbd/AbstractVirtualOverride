using AbstractVirtualOverride.AbstractClass;
using System;

namespace AbstractVirtualOverride.Business
{
    class SavingsAccount : BankAccount
    {
        public SavingsAccount(string accountName, string accountNumber, double interestAmount) : base(accountName, accountNumber)
        {
            InterestAmount = interestAmount;
            Console.WriteLine("Savings Account Parameters constructor is called.\n");
        }

        public double InterestAmount { set; get; }

        public override void TransferAmount(double transferAmount, string toAccountNo)
        {
            //implementation
            Console.WriteLine("Transfer Amount Implementation Logic: At Savings Account");
        }


        public override void WithdrawAmount(double withdrawAmount)
        {
            if (AccountBalance - withdrawAmount >= 0)
            {
                base.WithdrawAmount(withdrawAmount);
            }
            else
            {
                Console.WriteLine("Insufficient Balance.");
            }
        }

    }
}
