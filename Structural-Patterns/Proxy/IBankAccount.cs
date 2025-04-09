using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    // Step 1: Define the Subject Interface
    interface IBankAccount
    {
        void WithdrawMoney(double amount);
    }
}
