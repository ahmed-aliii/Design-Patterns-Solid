using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class BitCoinPayment : IPaymentStrategy
    {
        public void pay(double amount)
        {
            Console.WriteLine($"Paid {amount} using Bitcoin.");
        }
    }
}
