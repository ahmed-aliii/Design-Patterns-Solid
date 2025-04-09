


using Bridge;

namespace Brdige
{
    class Program
    {
        public static void Main(string[] args)
        {
            /*
             When to Use Bridge Pattern?
            ✅ When you need to decouple abstraction from implementation.
            ✅ When you have multiple dimensions of variation (e.g., different remotes for different devices).
            ✅ When you want to avoid deep inheritance hierarchies.
             */

            // Use a TV with a basic Oerations
            TV tv = new TV();   
            tv.TurnON();
            tv.TurnOff();

            Console.WriteLine();

            //Using Bridge Oerations
            RemoteControl remoteControl = new RemoteControl(tv);
            remoteControl.TurnOn();
            remoteControl.TurnOff();
            remoteControl.Mute();   


        }
    }
}