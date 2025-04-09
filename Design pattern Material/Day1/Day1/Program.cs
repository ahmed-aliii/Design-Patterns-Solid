using System;

namespace Day1
{
    internal class Program
    {
        static void Test(Developer dev)
        {
            try
            {
                dev.DoWork();
            }
            catch(DivideByZeroException ex)
            {

            }
        }

        static void Main(string[] args)
        {
            Developer dev1 = new Developer();
            Developer dev2 = new Developer();

            Test(dev1);
            Test(new Archtict());

            NetworkCard networkCard = NetworkCard.Create();

        }
    }
}
