using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    // Step 2: Create Concrete Flyweight (Shared Character)
    class Character : ICharacter
    {
        private readonly char _Symbol;

        public Character(char symbol) => _Symbol = symbol;


        public void Display() => Console.WriteLine($"char : {_Symbol}");
    }
}
