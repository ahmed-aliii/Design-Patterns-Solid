using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method
{
    class SMSNotification : INotifier
    {
        public void Send(string messege)
        {
            Console.WriteLine($"SMS Notification : {messege}");
        }
    }
}
