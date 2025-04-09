using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_Pattern
{
    class DataBase
    {
        //Holds The Only Instance Of This Class
        //static : To use it in the static class
        private static DataBase? instance = new DataBase();

        //Prevent Object Creation By Making Ctor private 
        private DataBase() { }

        //Define public class to use the Singleton
        // Instance in the outside world
        public static DataBase? GetInstance()
        {
            return instance;
        }
        public void Query(string query)
        {
            Console.WriteLine(query);
        }

    }
}
