using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{

    // Step 3: Define the Abstraction Bridge (Remote Control)
    class RemoteControl
    {
        protected IDevice _device;

        public RemoteControl(IDevice device)
        {
            _device = device;
        }

        public void TurnOn() => _device.TurnON();
        public void TurnOff() => _device.TurnOff();
        public void Mute() => Console.WriteLine($"Device {_device.GetType().Name} Is Muted");

    }
}
