using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method.Factory
{
    //step 1 : Create Abstract Class with Factory Method
    abstract class NotificationFactory
    {
        public abstract INotifier CreateNotification();  
    }
}
