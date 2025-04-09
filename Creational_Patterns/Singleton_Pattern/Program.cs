



namespace Singleton_Pattern
{
    class Program
    {
        public static void Main(string[] args)
        {
            //DataBase dataBase = new Database(); // Error


            DataBase db1 = DataBase.GetInstance();
            DataBase db2= DataBase.GetInstance();

            Console.WriteLine($"One Object = One Reference");
            Console.WriteLine($"DBSingleton : {db1.GetHashCode()}");
            Console.WriteLine($"DBSingleton2 : {db2.GetHashCode()}");
            Console.WriteLine();

            db1.Query("SELECT * FROM Employee");
            db2.Query("SELECT * FROM Employee");

        }
    }
}