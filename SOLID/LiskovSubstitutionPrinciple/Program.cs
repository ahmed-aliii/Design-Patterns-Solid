
using System;
using System.Drawing;
using System.Reflection.Metadata;
using System.Threading.Channels;
using static System.Runtime.InteropServices.JavaScript.JSType;




namespace LiskovSubstitutionPrinciple
{
    class Program
    {
        public static void Main(string[] args)
        {

            // Liskov Substitution Principle(LSP) in C#
            //"A Child should be able to replace its Parent class without breaking the behavior of the program."



            //🔴 Problem:
            //A Square should behave like a Rectangle, but changing width also changes height.
            // Square Not Have Width and Height => it just has SideLenghth
            //This violates LSP because it breaks the expectations of a rectangle.
            #region Bad Implementation & Problem
            //public class Rectangle
            //{
            //    public virtual int Width { get; set; }
            //    public virtual int Height { get; set; }

            //    public int GetArea() => Width * Height;
            //}

            //public class Square : Rectangle
            //{
            //    public override int Width
            //    {
            //        set { base.Width = base.Height = value; }
            //    }

            //    public override int Height
            //    {
            //      Square Not have a Height
            //       throw new NotImplementedException();
            //    }
            //}
            #endregion


            //To fix this, separate squares and rectangles instead of forcing inheritance.
            // separate Using Interface or Abstract Class => SRP + ISP
            #region Good Implementation & Soluation

            Shape rectangle = new Rectangle() { Width = 5, Height = 10 };
            Console.WriteLine($"Rectangle Area : {rectangle.GetArea()}");

            Shape square = new Square() { SideLength = 10};
            Console.WriteLine($"Square Area : {square.GetArea()}");

            #endregion

        }
    }

}