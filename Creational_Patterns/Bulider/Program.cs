



using Bulider;

namespace Builder
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Create Burger Using its builder Step-By-Step
            Burger burger = new BurgerBuilder()
                .SetBread("3esh balady")
                .AddCheese()
                .AddLettuce()
                .AddTomato()
                .Build(); //Bulid here

            burger.Show();


        }
    }
} 