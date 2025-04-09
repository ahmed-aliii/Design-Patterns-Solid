using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method.Factory
{
    //Step 2 : Concrete factories for each notification type
    class EmailNotificationFactory : NotificationFactory
    {
        public override INotifier CreateNotification()
        {
            return new EmailNotification();
        }
    }
}
