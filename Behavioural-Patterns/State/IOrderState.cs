using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    // Step 1: Define the State Interface
    interface IOrderState
    {
        void Handle(OrderContext orderContext); 
    }
}
