using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple
{
    class Square : Shape
    {
        public double SideLength { get; set; }
        public override double GetArea()
        {
            return SideLength * SideLength;
        }
    }
}
