using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    //Apply Strategy
    class ShoppingCart
    {
        IPaymentStrategy _paymentStrategy;

        //Assgin _paymentStrategy
        public void SetPaymentStrategy(IPaymentStrategy paymentStrategy)
        {
            _paymentStrategy = paymentStrategy;
        }

        //Invoke Payment Strategy
        public void Checkout(double amount)
        {
            if (_paymentStrategy == null)
            {
                Console.WriteLine("Please, Assign Your Payment Method! ");
                return;
            }
            _paymentStrategy.pay(amount);
        }
    }
}
