using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Decorator
{
    // Step 2: Create the Concrete Component (Basic Coffee)
    //Tight class
    class SimpleCoffe : ICoffee
    {
        public double GetCost()
            => 10.0;
        public string GetDiscrption()
            => "Simple Black Coffee";
    }
}
