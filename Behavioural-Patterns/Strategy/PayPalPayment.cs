using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class PayPalPayment : IPaymentStrategy
    {
        public void pay(double amount)
        {
            Console.WriteLine($"Paid {amount} using PayPal.");
        }
    }
}
