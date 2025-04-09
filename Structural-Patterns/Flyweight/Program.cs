

namespace Flyweight
{
    class Program
    {
        public static void Main(string[] args)
        {
            /*
             🔹 When to Use Flyweight Pattern?
                ✅The Flyweight Pattern is used to reduce memory usage by sharing objects instead of creating new ones. 
                    It is useful when you have a large number of similar objects that can share common data.
                ✅ When an application has a large number of similar objects.
                ✅ When memory usage is a concern and object reuse is possible.
             */


            // without Flyweight Pattern
            Console.WriteLine("Without Flyweight Pattern");
            Character char1 = new Character('A');
            Character char2 = new Character('A');

            Console.WriteLine($"char1 => {char1.GetHashCode()}");
            Console.WriteLine($"char2 => {char2.GetHashCode()}");

            Console.WriteLine();

            // Step 4: Using the Flyweight Pattern
            Console.WriteLine("Using the Flyweight Pattern");
            CharacterFactory factory = new CharacterFactory();

            ICharacter ch1 = factory.GetCharacter('A'); 
            ICharacter ch2 = factory.GetCharacter('A');
            
            Console.WriteLine($"ch1 => {ch1.GetHashCode()}");
            Console.WriteLine($"ch2 => {ch2.GetHashCode()}");

        }
    }
}