using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;





namespace Abstract_Factory.Fartory
{
    //Create concrete factories for Windows 
     class WindowsFactory : IUIFactory
    {
        public ICheckBox GetCheckBox()
        {
            return new WindowsCheckBox();
        }

        public IButton GetButton()
        {
            return new WindowsButton();
        }
    }
}
