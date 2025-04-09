using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    // Step 2: Create the Real Object (Actual Bank Account)
    class BankAccount : IBankAccount
    {
        private double _balance = 1000; // Initial balance

        public void WithdrawMoney(double amount)
        {
            if(amount > _balance)
            {
                Console.WriteLine("Insufficient balance!");
            }
            else
            {
                _balance -= amount;
                Console.WriteLine($"Withdrawn: ${amount}, Remaining Balance: ${_balance}");
            }
        }
    }
}
