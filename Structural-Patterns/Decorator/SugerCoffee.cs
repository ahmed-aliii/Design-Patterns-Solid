using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class SugerCoffee : CoffeeDecrator
    {
        public SugerCoffee(ICoffee coffee) : base(coffee) { }
        public double GetCost() => 10.0 + 0.5 + 4;
        public string GetDiscrption() => "Suger Coffee";

    }
}
