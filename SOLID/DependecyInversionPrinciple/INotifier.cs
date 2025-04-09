using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependecyInversionPrinciple
{
    //Low_Level Classes Interface
    interface INotifier
    {
        public void Send(string messege);
    }
}
