﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory.Fartory
{
    //Define an Abstract Factory interface
    interface IUIFactory
    {
         IButton GetButton();
         ICheckBox GetCheckBox();


    }
}
