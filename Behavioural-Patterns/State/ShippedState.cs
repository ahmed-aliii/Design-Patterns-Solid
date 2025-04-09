using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    class ShippedState : IOrderState
    {
        public void Handle(OrderContext orderContext)
        {
            Console.WriteLine("Order is now Shipping.");
            orderContext.SetState(new DeliveredState()); // Move to the next state
        }
    }
}
