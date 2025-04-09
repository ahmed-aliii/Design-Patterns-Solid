using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependecyInversionPrinciple
{
    //High-Level Business Class
    //Depend on Abstraction(Interfaces) Not Low-Level Classes
    class NotificationService
    {
        private readonly INotifier _notifier;

        public NotificationService(INotifier notifier)
        {
            _notifier = notifier;
        }

        public void SendNotification(string messege)
        {
            _notifier.Send(messege);
        }

    }
}
