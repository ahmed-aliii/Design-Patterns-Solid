using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    // Step 3: Flyweight Factory (Manages Character Objects)
    class CharacterFactory
    {
        private readonly Dictionary<char, ICharacter> _characterMap = new Dictionary<char, ICharacter>();

        public ICharacter GetCharacter(char symbol)
        {
            if (!_characterMap.ContainsKey(symbol))
            {
                _characterMap.Add(symbol , new Character(symbol));
            }
            return _characterMap[symbol];
        }
    }
}
