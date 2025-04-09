using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    // Step 4: Child Decorator 
    class MilkCoffee : CoffeeDecrator
    {
        public MilkCoffee(ICoffee coffee) : base(coffee) { }
        public double GetCost() => 10.0 + 0.5 + 3.3;
        public string GetDiscrption() => "Milk Coffee";
    }
}
