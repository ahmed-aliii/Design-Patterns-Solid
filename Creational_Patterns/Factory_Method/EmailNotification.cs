using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method
{
    class EmailNotification : INotifier
    {
        public void Send(string messege)
        {
            Console.WriteLine($"Email Notification : {messege}");
        }
    }
}
