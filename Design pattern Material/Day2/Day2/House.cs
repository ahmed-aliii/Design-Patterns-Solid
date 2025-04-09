using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    internal class House
    {
        List<IOption> Options = new List<IOption>();

        public Garden Garden { get; set; }
        public SwimmingPool SwimmingPool { get; set; }
        public Jacosi Jacosi { get; set; }
    }
}
