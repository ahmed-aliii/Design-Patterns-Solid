using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    class WindowsCheckBox : ICheckBox
    {
        public void Render()
            => Console.WriteLine("Windows CkeckBox");
    }
}
