using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    // Step 2: Create Concrete Strategies
    class CreditPayment : IPaymentStrategy
    {
        public void pay(double amount)
        {
            Console.WriteLine($"Paid {amount} using Credit Card.");
        }
    }
}
