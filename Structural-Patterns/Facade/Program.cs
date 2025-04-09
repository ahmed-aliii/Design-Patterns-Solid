



namespace Facade
{
    class Program
    {
        public static void Main(string[] args)
        {
            /*
             🔹 When to Use Facade Pattern?
                ✅ When working with complex subsystems and want to simplify their use.
                ✅ When you need a single entry point to an entire system.
             */

            // Instead of interacting with multiple services, we use the Facade
            HotelFacade hotel = new HotelFacade();
            hotel.RequestFullHotelServices();
        }
    }
}