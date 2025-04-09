using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulider
{
    // Step 1: Define the product (Burger)
    public class Burger
    {
        public string? Bread { get; set; }
        public bool Cheese { get; set; }
        public bool Lettuce { get; set; }
        public bool Tomato { get; set; }
        public bool DoublePatty { get; set; }

        public void Show()
        {
            Console.WriteLine($"Burger with: Bread={Bread}, Cheese={Cheese}, Lettuce={Lettuce}, Tomato={Tomato}, DoublePatty={DoublePatty}");
        }
    }
}
