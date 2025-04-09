using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    // Step 2: Create the Leaf Class (File)
    class File : IFileSystemItem
    {
        private readonly string _name;

        public File(string name) => _name = name;

        public void ShowDetails() => Console.Write($" {this._name}  ");
    }
}
