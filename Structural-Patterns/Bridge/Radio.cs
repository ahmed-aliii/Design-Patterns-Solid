using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    // Step 2: Create Concrete Implementations Radio
    class Radio : IDevice
    {
        public void TurnOff() => Console.WriteLine("Radio Turned OFF");
        public void TurnON() => Console.WriteLine("Radio Turned ON");
    }
}
