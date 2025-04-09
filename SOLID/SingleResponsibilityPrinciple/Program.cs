using SingleResponsibilityPrinciple;
using System;
using System.Reflection.Metadata;
using static System.Runtime.InteropServices.JavaScript.JSType;




namespace SingleResponsibiltyPrincilple
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Single Responsibility Principle(SRP) in C#
            //Ensures that one class should have only one reason to change—it
            //should focus on a single responsibility.

            #region Bad Parctice

            //🚫 Bad Example(Violating SRP)
            //Here, the Employee class has multiple responsibilities:
            //1) Storing employee data.
            //2) Calculating salary.
            //3) Saving employee data to a database

            //public class Employee
            //{
            //    public string Name { get; set; }
            //    public double Salary { get; set; }

            //    public double CalculateSalary()
            //    {
            //        // Salary calculation logic
            //        return Salary * 1.1; // Example with a 10% bonus
            //    }

            //    public void SaveToDatabase()
            //    {
            //        // Database save logic (this shouldn't be here)
            //        Console.WriteLine("Employee saved to database.");
            //    }
            //}

            #endregion

            #region Good Practice
            //✅ Good Example(Following SRP)
            //We will separate concerns:
            //1) Employee → Handles only employee data.
            //2) SalaryCalculator → Handles salary calculations.
            //3) EmployeeRepository → Handles database operations.

            Employee Ahmed = new Employee() { Id = 1, Name = "Ahmed", Salary = 1000 };
            Console.WriteLine(Ahmed.ToString());

            SalaryCalculator salaryCalculator = new SalaryCalculator();
            Console.WriteLine($"Employee Salay After Commesion : {salaryCalculator.CaluculateSalay(Ahmed)}");

            DataHandler dataHandler = new DataHandler();
            dataHandler.HandleData(Ahmed);

            #endregion




        }
    }

}