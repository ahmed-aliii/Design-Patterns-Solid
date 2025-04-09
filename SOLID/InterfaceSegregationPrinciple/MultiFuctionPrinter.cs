using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple 
{
    class MultiFuctionPrinter : IPrinter, IFax, ISanner
    {
        public void Fax()
            => Console.WriteLine("MultiFunctionPrinter : Fax"); 

        public void Print()
            => Console.WriteLine("MultiFunctionPrinter : Print"); 

        public void Scan()
            => Console.WriteLine("MultiFunctionPrinter : Scan"); 
    }
}
