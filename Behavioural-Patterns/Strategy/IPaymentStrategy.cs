using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    interface IPaymentStrategy
    {
        // Step 1: Define the Strategy Interface
        void pay(double amount);
    }
}
