


namespace Strategy
{
    class Program
    {
        public static void Main(string[] args)
        {
            /*
                Strategy Pattern
                🔹 Intent
                1) The Strategy Pattern allows you to define a family of algorithms, encapsulate them in separate classes.
                2) It helps to avoid long if-else or switch-case statements
                3) Apply Open/Closed Principle
             */

            ShoppingCart cart = new ShoppingCart();

            // Pay with Credit Card
            cart.SetPaymentStrategy(new CreditPayment());
            cart.Checkout(300);

            Console.WriteLine();

            // Pay with PayPal 
            cart.SetPaymentStrategy(new PayPalPayment());
            cart.Checkout(300);

            Console.WriteLine();

            // Pay with Bitcoin
            cart.SetPaymentStrategy(new BitCoinPayment());
            cart.Checkout(300);

        }
    }
}