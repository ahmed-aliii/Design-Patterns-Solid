using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method
{
    //Notifier Interface For all Notification Classes
    interface INotifier
    {
        void Send(string messege);
    }
}
