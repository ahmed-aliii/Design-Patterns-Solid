using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    // Step 1: Define the Component Interface
    interface ICoffee
    {
        string GetDiscrption();
        double GetCost();
    }
}
