using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    class WindowsButton : IButton
    {
        public void Render()
            => Console.WriteLine("Windows Button");
    }
}
