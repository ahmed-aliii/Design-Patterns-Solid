using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    internal abstract class Company
    {
        List<IEmployee> employees;

        public abstract void CreateEmpoyees();

        public void CreateSoftware()
        {
            foreach (var item in employees)
            {
                item.DoWork();
            }
        }
    }
}
