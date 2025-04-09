using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    internal class Rectangle
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public int CalculateArea()
        {
            return Width * Height;
        }
    }
}
