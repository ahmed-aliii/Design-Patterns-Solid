namespace State 
{
    class Program
    {
        public static void Main(string[] args)
        {
            /*
               tate Pattern
                🔹 Intent
                1) The State Pattern allows an object to change its behavior when its internal state changes, 
                    without using complex if-else or switch-case statements.
                2) It encapsulates different behaviors into separate state classes, 
             */


            OrderContext order = new OrderContext();

            // Process the order through different states
            order.ProcessOrder(); // Output: Order is now Pending.
            order.ProcessOrder(); // Output: Order has been Shipped.
            order.ProcessOrder(); // Output: Order has been Delivered.
        }
    }
}