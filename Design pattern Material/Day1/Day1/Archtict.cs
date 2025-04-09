using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    internal class Archtict : Developer
    {
        public override void DoWork()
        {
            base.DoWork();

            throw new FileNotFoundException();
        }

        public override void MyFunc(int x)
        {
            if (x < 0)
                return;

        }
    }
}
