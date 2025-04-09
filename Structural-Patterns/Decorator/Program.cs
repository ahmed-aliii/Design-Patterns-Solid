




namespace Decorator
{

    class Program
    {
        public static void Main(string[] args)
        {
            /*
             🔹 When to Use Decorator Pattern?
                ✅ When you want to add/Modify functionality of the Existed methods
                    dynamically without modifying existing code in existed class.
                ✅ Apply Open/Closed Principle
             */

            //Simple Coffee
            SimpleCoffe simpleCoffee = new SimpleCoffe();
            Console.WriteLine($"Discription: {simpleCoffee.GetDiscrption()} :: Cost: {simpleCoffee.GetCost()}");

            Console.WriteLine();

            //Decorated Milk Coffee
            MilkCoffee MC = new MilkCoffee(new SimpleCoffe());
            Console.WriteLine($"Discription: {MC.GetDiscrption()} :: Cost: {MC.GetCost()}");

            Console.WriteLine();

            //Decorated Suger Coffee
            SugerCoffee SC = new SugerCoffee(new SimpleCoffe());
            Console.WriteLine($"Discription: {SC.GetDiscrption()} :: Cost: {SC.GetCost()}");

        }
    }
}