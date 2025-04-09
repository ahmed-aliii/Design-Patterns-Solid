using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    // Step 3: Create the Composite Class (Folder) 
    class Folder : IFileSystemItem
    {
        private readonly string _name;
        private readonly List<IFileSystemItem> _items = new List<IFileSystemItem>();

        public Folder(string name) => _name = name;


        public void AddItem(IFileSystemItem item) => _items.Add(item);

        public void ShowDetails()
        {
            Console.WriteLine($"Folder : {this._name}");
            foreach(var item in _items)
            {
                item.ShowDetails();
            }
            Console.WriteLine();
        }
    }
}
