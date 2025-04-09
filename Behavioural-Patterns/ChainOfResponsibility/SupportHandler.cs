using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    // Step 1: Define an Abstract Handler
    abstract class SupportHandler
    {
        protected SupportHandler _nextHandler;

        public void SetNextHandler(SupportHandler nextHandler)
        {
            _nextHandler = nextHandler;
        }

        public abstract void HandleRequest(string issue);

    }
}
