using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    class OrderContext
    {
        private IOrderState _orderState;


        //Inatial State
        public OrderContext()
        {
            _orderState = new PendingOrder(); 
        }

        public void SetState(IOrderState orderState)
        {
            _orderState = orderState;
        }

        //Process According to the current state
        public void ProcessOrder()
        {
            _orderState.Handle(this);
        }
    }
}
