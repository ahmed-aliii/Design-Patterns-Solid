using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    class PendingOrder : IOrderState
    {
        public void Handle(OrderContext orderContext)
        {
            Console.WriteLine("Order is now Pending.");
            orderContext.SetState(new ShippedState()); // Move to the next state
        }
    }
}
