using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoType
{
    // Step 1: Define a Prototype Interface
    //With The Clone Function
    interface IDocumentProtoType
    {
        IDocumentProtoType Clone();
        void Show();
    }
}
