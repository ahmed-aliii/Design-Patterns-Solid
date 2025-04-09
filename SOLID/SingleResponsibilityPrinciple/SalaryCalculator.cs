using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple
{
    //2) SalaryCalculator → Handles salary calculations.
    class SalaryCalculator : ISalaryClaculator<Employee>
    {
        public double CaluculateSalay(Employee employee)
        {
            return employee.Salary * 1.1;
        }
    }
}
