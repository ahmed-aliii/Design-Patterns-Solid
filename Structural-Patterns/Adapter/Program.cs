
using System.ComponentModel;

namespace Adapter
{
    class Program
    {
        public static void Main(string[] args)
        {
            /*
             When to Use Adapter Pattern?
            ✅ When you need to convert one interface into another.
            ✅ When integrating legacy code with a modern system.
             */

            // We have an Egyptian plug
            EgyptianPlug egyptianPlug = new EgyptianPlug();
            egyptianPlug.PlugIntoEgyptianSocket();
            Console.WriteLine();

            // We use an adapter to make it compatible with a UK socket
            SocketAdapter socketAdapter = new SocketAdapter(egyptianPlug);

            // Now we can plug it into a UK socket
            socketAdapter.PlugIntoUKSocket();

        }
    }
}
