

using System;
using System.Reflection;
using System.Reflection.PortableExecutable;
using System.Runtime.Intrinsics.X86;

namespace InterfaceSegregationPrinciple
{

    class Program
    {
        public static void Main(string[] args)
        {
            //Interface Segregation Principle(ISP) in C#
            //This means large interfaces should be split into smaller, more specific interfaces
            //to avoid forcing classes to implement methods they don’t need.
            //Clients should not be forced to depend on interfaces they do not use.



            //🚫 Bad Example(Violating ISP)
            //Here, the IMachine interface includes multiple responsibilities:
            //Print()
            //Scan()
            //Fax()
            //However, not all machines need all these functionalities.
            #region Bad Example

            //🔴 Problems:
            //BasicPrinter is forced to implement methods it does not need.
            //Throwing exceptions for unsupported methods is a sign of bad design.
            //Violates ISP because clients(printers) must implement methods they don’t use.


            //public interface IMachine
            //{
            //    void Print();
            //    void Scan();
            //    void Fax();
            //}

            //// ✅ Works fine for multi-function printers
            //public class MultiFunctionPrinter : IMachine
            //{
            //    public void Print() => Console.WriteLine("Printing...");
            //    public void Scan() => Console.WriteLine("Scanning...");
            //    public void Fax() => Console.WriteLine("Faxing...");
            //}

            //// 🚨 Violates ISP - A simple printer is forced to implement Scan and Fax
            //public class BasicPrinter : IMachine
            //{
            //    public void Print() => Console.WriteLine("Printing...");

            //    public void Scan()
            //    {
            //        throw new NotImplementedException("This printer does not support scanning.");
            //    }

            //    public void Fax()
            //    {
            //        throw new NotImplementedException("This printer does not support faxing.");
            //    }
            //}
            #endregion


            // ✅ Good Example(Following ISP)
            //To fix this, split the large interface into smaller, more focused interfaces.
            //Solution: Use Separate Interfaces
            #region Good Example

            BasicPrinter printer = new BasicPrinter();
            printer.Print();
            Console.WriteLine();

            MultiFuctionPrinter multiFuctionPrinter = new MultiFuctionPrinter();
            multiFuctionPrinter.Print();
            multiFuctionPrinter.Fax();
            multiFuctionPrinter.Scan();


            #endregion


        }
    }
}
