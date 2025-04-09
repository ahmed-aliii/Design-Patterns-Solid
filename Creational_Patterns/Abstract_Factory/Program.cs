

using Abstract_Factory.Factory;
using Abstract_Factory.Fartory;

namespace Abstract_Factory
{
    class Program
    {
        public static void Main(string[] args)
        {

            // Select factory based on OS type
            IUIFactory OSFactory;

            //Windows OS
            OSFactory = new WindowsFactory();
            IButton windowsButton = OSFactory.GetButton();
            ICheckBox windowsCheckBox = OSFactory.GetCheckBox();

            windowsButton.Render();
            windowsCheckBox.Render();
            Console.WriteLine();


            //Mac Os
            OSFactory = new MacFactory();
            IButton macButton = OSFactory.GetButton();
            ICheckBox macCheckBox = OSFactory.GetCheckBox();

            macButton.Render();
            macCheckBox.Render();
            Console.WriteLine();
        }
    }
}