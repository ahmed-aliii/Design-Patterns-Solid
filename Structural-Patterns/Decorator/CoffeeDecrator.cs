using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    // Step 3: Parent Decorator 
    class CoffeeDecrator : ICoffee
    {
        protected ICoffee _coffee;

        public CoffeeDecrator(ICoffee coffee)
        {
            _coffee = coffee;
        }

        public double GetCost() => 10.0 + 0.5;
        public string GetDiscrption() => "Decorated Coffee";
    }
}
