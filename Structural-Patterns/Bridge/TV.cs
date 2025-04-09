using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    // Step 2: Create Concrete Implementations TV 
    class TV : IDevice
    {
        public void TurnOff() => Console.WriteLine("TV Turned OFF");
        public void TurnON() => Console.WriteLine("TV Turned ON");
    }
}
