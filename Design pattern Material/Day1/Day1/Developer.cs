using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    internal class Developer : IEmployee
    {
        public Developer()
        {
            Logger.Log("Developer created");
        }

        public virtual void DoWork()
        {
            throw new DivideByZeroException();
        }

        public virtual void MyFunc(int x)
        {

        }
    }
}
