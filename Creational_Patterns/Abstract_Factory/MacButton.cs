﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    class MacButton : IButton
    {
        public void Render()
            => Console.WriteLine("MAC Button");
    }
}
