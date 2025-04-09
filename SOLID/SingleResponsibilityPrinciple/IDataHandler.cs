using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple
{
    interface IDataHandler<T>
    {
        public void HandleData(T dataObj);
    }
}
