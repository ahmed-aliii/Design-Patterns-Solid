using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    // Step 1: Define the Implementor Interface (Device)
    interface IDevice
    {
        void TurnON();
        void TurnOff();
    }
}
