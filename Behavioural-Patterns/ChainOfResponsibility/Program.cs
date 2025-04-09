


namespace ChainOfResponsibility
{
    class Program
    {
        public static void Main(string[] args)
        {
            /*
                Chain of Responsibility Pattern
                🔹 Intent
                The Chain of Responsibility Pattern allows multiple objects to handle a request one after another.
             */


            //Object of the chain 
            BasicSupoort employee = new BasicSupoort();
            SuperviserSupport superviser = new SuperviserSupport();
            ManagerSupport manager = new ManagerSupport();

            // Assign The chain of Responsibilty
            employee.SetNextHandler(superviser);
            superviser.SetNextHandler(manager);

            // Making requests
            employee.HandleRequest("password reset");  // Handled by Basic Support
            Console.WriteLine();
            employee.HandleRequest("billing issue");   // Handled by Supervisor
            Console.WriteLine();
            employee.HandleRequest("server crash");    // Handled by Manager

        }
    }
} 