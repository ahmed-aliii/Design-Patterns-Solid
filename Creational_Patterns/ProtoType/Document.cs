using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace ProtoType
{
    // Step 2: Create a Concrete Prototype class (Document)
    class Document : IDocumentProtoType
    {
        public string Title { get; set; }
        public string Content { get; set; }


        //Copy Ctor => 2nd way To clone Object
        public Document(Document obj)
        {
            Title = obj.Title;
            Content = obj.Content;
        }

        //Cloning Ctor For Method Clone
        public Document(string _Title , string _Content)
        {
            Title = _Title;
            Content = _Content;
        }

        //Clone State Not Reference
        public IDocumentProtoType Clone()
        {
            return new Document(this.Title , this.Content);
        }

        public void Show()
            => Console.WriteLine($"Title: {Title} :: Content: {Content}");
    }
}
