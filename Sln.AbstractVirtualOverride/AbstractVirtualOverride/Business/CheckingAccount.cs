using AbstractVirtualOverride.AbstractClass;
using System;

namespace AbstractVirtualOverride.Business
{
    class CheckingAccount: BankAccount
    {
        public CheckingAccount()
        {
            Console.WriteLine("Checking Account default constructor is called.\n");
        }

        public override void TransferAmount(double transferAmount, string toAccountNo)
        {
            //implementation
            Console.WriteLine("Transfer Amount Implementation Logic: At Checking Account");
        }
    }
}
