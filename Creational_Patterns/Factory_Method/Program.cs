
using Factory_Method.Factory;

namespace Factory_Method
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Notification Factory
            NotificationFactory factory;

            //Create an Email Notification
            factory = new EmailNotificationFactory();
            INotifier email = factory.CreateNotification();
            email.Send("Hello Via Email");
            Console.WriteLine();

            //Create a SMS Notification
            factory = new SMSNotificationFactory();
            INotifier sms = factory.CreateNotification();
            sms.Send("Hello Via SMS");

        }
    }
}