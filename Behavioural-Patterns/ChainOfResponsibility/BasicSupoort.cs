using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    // Step 2: Create Concrete Handlers
    class BasicSupoort : SupportHandler
    {
        public override void HandleRequest(string issue)
        {
            if(issue == "password reset")
            {
                Console.WriteLine("Basic Support: Resolved password reset issue.");
            }
            else if(_nextHandler != null)
            {
                Console.WriteLine("Basic Support: Forwarding request...");
                _nextHandler.HandleRequest(issue);
            }
            else
            {
                Console.WriteLine("No handler available for this request.");
            }
        }
    }
}
