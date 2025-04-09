using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    class DeliveredState : IOrderState
    {
        public void Handle(OrderContext orderContext)
        {
            Console.WriteLine("Order has been Delivered."); //Last State
        }
    }
}
