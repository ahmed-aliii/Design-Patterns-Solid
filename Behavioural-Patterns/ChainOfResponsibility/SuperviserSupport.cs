using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    // Step 2: Create Concrete Handlers
    class SuperviserSupport : SupportHandler
    {
        public override void HandleRequest(string issue)
        {
            if(issue == "billing issue")
            {
                Console.WriteLine("Supervisor: Resolved billing issue.");
            }
            else if (_nextHandler != null)
            {
                Console.WriteLine("Supervisor: Forwarding request...");
                _nextHandler.HandleRequest(issue);
            }
            else
            {
                Console.WriteLine("No handler available for this request.");
            }
        }
    }
}
