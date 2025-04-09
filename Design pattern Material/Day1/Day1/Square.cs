using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    internal class Square : Rectangle
    {
        Rectangle rectangle = new Rectangle();

        public int Length
        {
            set
            {
                rectangle.Width = rectangle.Height = value;
            }
            get
            {
                return rectangle.Width;
            }
        }

        public int CalculateArea()
        {
            return rectangle.CalculateArea();
        }
    }
}
