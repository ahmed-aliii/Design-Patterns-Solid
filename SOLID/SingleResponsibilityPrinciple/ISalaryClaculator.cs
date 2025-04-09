using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple
{
    interface ISalaryClaculator<T>
    {
        public double CaluculateSalay(T AnyTypeOFEmployee);
    }
}
