using Abstract_Factory.Fartory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory.Factory
{
    //Create concrete factories for Mac 
    class MacFactory : IUIFactory
    {
        public IButton GetButton()
        {
            return new MacButton();
        }

        public ICheckBox GetCheckBox()
        {
            return new MacCkeckBox();
        }
    }
}
