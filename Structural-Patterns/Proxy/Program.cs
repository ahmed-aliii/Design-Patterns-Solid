

namespace Proxy
{
    class Program
    {
        public static void Main(string[] args)
        {
            /*Intent
             1) The Proxy Pattern provides a placeholder for another object to control access to it.
             2) It is used to add extra functionality like lazy initialization, access control, 
                logging, or security without modifying the original object.
             */


            //BankAccount 
            BankAccount bankAccount = new BankAccount();
            bankAccount.WithdrawMoney(500);
            bankAccount.WithdrawMoney(600);

            Console.WriteLine();

            //ATM Proxy BankAccount
            ATMProxy ATMProxyAcount = new ATMProxy();
            ATMProxyAcount.WithdrawMoney(500);
            ATMProxyAcount.WithdrawMoney(500);
            ATMProxyAcount.WithdrawMoney(500);
            ATMProxyAcount.WithdrawMoney(600);

        }
    }
}