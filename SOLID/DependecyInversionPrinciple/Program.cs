using System.Reflection.Emit;
using System.Runtime.Intrinsics.Arm;
using System.Runtime.Intrinsics.X86;






namespace DependecyInversionPrinciple
{
    class Program
    {
        public static void Main(string[] args)
        {
            //The Dependency Inversion Principle(DIP) states:
            //"High-level modules should not depend on low-level modules =>  Both should depend on abstractions."
            //This means we should depend on interfaces(abstractions) rather than concrete implementations
            //  to make our code flexible, testable, and maintainable.
            #region Bad Example

            //🚫 Bad Example(Violating DIP)
            //A NotificationService depends directly on EmailNotifier, making it hard to change

            //public class EmailNotifier
            //{
            //    public void SendEmail(string message)
            //    {
            //        Console.WriteLine($"Email sent: {message}");
            //    }
            //}

            //public class NotificationService
            //{
            //    private EmailNotifier _emailNotifier;

            //    public NotificationService()
            //    {
            //        _emailNotifier = new EmailNotifier(); // 🚨 Direct dependency (bad)
            //    }

            //    public void SendNotification(string message)
            //    {
            //        _emailNotifier.SendEmail(message);
            //    }
            //}


            #endregion



            #region Good Example
            
            //Key Takeaways for DIP
            //✔ High - level modules(business logic) should not depend on low - level modules(database, notifications, etc.).
            //✔ Both should depend on abstractions(interfaces).
            //✔ Abstractions should not depend on details; details should depend on abstractions.
            //✔ Use Dependency Injection(DI) to pass dependencies instead of hardcoding them.

            //Good Example(Following DIP)
            //Introduce an interface (INotifier) so NotificationService depends on an abstraction.
            
            INotifier emailNotifier = new EmailNotifier();
            INotifier SMSNotifier = new SMSNotifier();

            NotificationService notificationService = new NotificationService(emailNotifier);
            notificationService.SendNotification("This is Email");

            notificationService = new NotificationService(SMSNotifier);
            notificationService.SendNotification("This is SMS");

            #endregion

        }
    }
}