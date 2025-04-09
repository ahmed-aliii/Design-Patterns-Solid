using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    // Step 3: Create an Adapter that Converts Egyptian Plug to UK Socket
    class SocketAdapter : IUKSocket
    {
        private readonly EgyptianPlug _egyptianPlug;

        public SocketAdapter(EgyptianPlug egyptianPlug)
        {
            _egyptianPlug = egyptianPlug;
        }

        // Convert Egyptian plug to UK socket
        public void PlugIntoUKSocket()
        {
            Console.WriteLine("Using Adabter Plug Into UK Socket by Egyptian Plug ");
            _egyptianPlug.PlugIntoEgyptianSocket();
        }
    }
}
