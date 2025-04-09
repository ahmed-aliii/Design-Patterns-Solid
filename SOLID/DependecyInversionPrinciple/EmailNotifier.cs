using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependecyInversionPrinciple
{
    //Low_Level Class
    class EmailNotifier : INotifier
    {
        public void Send(string messege)
        {
            Console.WriteLine($"Send Email Notification : {messege}");
        }
    }
}
