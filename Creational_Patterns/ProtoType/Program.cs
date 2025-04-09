
namespace ProtoType
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Create First - Original Object 
            Document document1 = new Document("HTML", "Book About Software Engineering");
            Console.WriteLine("------document1-------");
            document1.Show();

            Console.WriteLine();

            //Create ProtoType using Clone method
            Document document2 = (Document) document1.Clone();
            document2.Title = "CSS";
            Console.WriteLine("------document2-------");
            document2.Show();

            Console.WriteLine();

            //Create ProtoType using Copy Ctor
            Document document3 = new Document(document1);
            Console.WriteLine("------document3-------");
            document3.Show();
        }
    }
}