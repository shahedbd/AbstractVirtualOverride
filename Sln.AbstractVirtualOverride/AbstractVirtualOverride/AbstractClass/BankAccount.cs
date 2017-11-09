using System;

namespace AbstractVirtualOverride.AbstractClass
{
    public abstract class BankAccount
    {
        public BankAccount()
        {
            Console.WriteLine("Bank Account default constructor is called.\n");
        }
        public BankAccount(string accountName, string accountNumber)
        {
            AccountName = accountName;
            AccountNumber = accountNumber;
            Console.WriteLine("Bank Account Parameters constructor is called.\n");
        }

        public string AccountName { set; get; }
        public string AccountNumber { set; get; }
        public double AccountBalance { protected set; get; }


        //01: Not implemented
        public abstract void TransferAmount(double transferAmount, string toAccountNo);

        //02: Partial implemented
        public virtual void WithdrawAmount(double withdrawAmount)
        {
            AccountBalance -= withdrawAmount;
        }

        //03: Full implemented
        public void DepositAmount(double depositAmount)
        {
            AccountBalance = AccountBalance + depositAmount;
        }

    }
}
