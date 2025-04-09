using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{    // Step 2: Create Concrete Handlers
    class ManagerSupport : SupportHandler
    {
        public override void HandleRequest(string issue)
        {
            Console.WriteLine("Manager: Handling complex issue: " + issue);
        }
    }
}
