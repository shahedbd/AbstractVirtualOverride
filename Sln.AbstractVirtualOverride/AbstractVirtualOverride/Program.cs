using AbstractVirtualOverride.AbstractClass;
using AbstractVirtualOverride.Business;
using System.Collections.Generic;
using static System.Console;

namespace AbstractVirtualOverride
{
    class Program
    {
        static void Main(string[] args)
        {
            CheckingAccount _CheckingAccount = new CheckingAccount();
            _CheckingAccount.DepositAmount(2000);
            _CheckingAccount.WithdrawAmount(500);
            _CheckingAccount.AccountNumber = "Acc.Chk-101";
            WriteLine("Checking Account Balance 01: " + _CheckingAccount.AccountBalance);


            SavingsAccount _SavingsAccount = new SavingsAccount("Rahim Islam", "Acc.Sav-102", 500);
            _SavingsAccount.InterestAmount = 200;
            _SavingsAccount.DepositAmount(1000);
            _SavingsAccount.WithdrawAmount(500);
            WriteLine("Savings Account Balance 01: " + _SavingsAccount.AccountBalance);


            List<BankAccount> bankAccountList = new List<BankAccount>();
            bankAccountList.Add(_SavingsAccount);
            bankAccountList.Add(_CheckingAccount);

            foreach (BankAccount bankAccount in bankAccountList)
            {
                bankAccount.WithdrawAmount(100);
            }
            WriteLine("Checking Account Balance 02: " + _CheckingAccount.AccountBalance);
            WriteLine("Savings Account Balance 02: " + _SavingsAccount.AccountBalance);



            BankAccount bankAccount2 = _SavingsAccount;  //upcasting
            SavingsAccount _SavingsAccount2 = (SavingsAccount)bankAccount2;    //downcasting
            WriteLine("Savings Account Interest Amount: " + _SavingsAccount2.InterestAmount);



            Print(_SavingsAccount);
            Print(_CheckingAccount);

            ReadKey();
        }

        public static void Print(BankAccount bankAccount)
        {
            WriteLine("Account No: "+ bankAccount.AccountNumber);
        }
    }
}
