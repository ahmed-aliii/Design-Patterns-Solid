using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple
{
    class BasicPrinter : IPrinter
    {
        public void Print() 
        {
            Console.WriteLine($"Basic Printer : Print ");
        }
    }
}
