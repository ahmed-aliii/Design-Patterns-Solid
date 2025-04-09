using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple
{
    class DataHandler : IDataHandler<Employee>
    {
        public void HandleData(Employee employee)
        {
            Console.WriteLine($"Save Employee {employee.Name} To dataBase");
        }
    }
}
