using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    // Step 3: Create the Proxy Class (ATM)
    class ATMProxy : IBankAccount
    {
        private readonly BankAccount _realAccount = new BankAccount();
        public void WithdrawMoney(double amount)
        {
            Console.WriteLine("ATM Processing request...");
            if (amount > 500) // ATM Limit
            {
                Console.WriteLine("ATM Limit Exceeded! Cannot withdraw more than $500 at a time.");
                return;
            }

            _realAccount.WithdrawMoney(amount); // Forward request to real object
        }
    }
}
