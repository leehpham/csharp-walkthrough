using System;
using System.Collections.Generic;

namespace DelegateDemo
{
    // Declare the delegate
    public delegate bool IsPromotable(Employee empl);

    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }        
        public int Experience { get; set; }

        // The delegate will be passed into the method as an argument.
        // Techinically, the method is taking in another method as a parameter.
        public static void PromoteEmployee(List<Employee> employeeList, IsPromotable IsEligibleToPromote)
        {
            foreach (Employee employee in employeeList)
            {
                if (IsEligibleToPromote(employee))
                {
                    Console.WriteLine(employee.Name + " promoted");
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> empList = new List<Employee>();

            empList.Add(new Employee
            {
                ID = 101,
                Name = "Mary",
                Salary = 5000,
                Experience = 5
            });
            empList.Add(new Employee
            {
                ID = 101,
                Name = "Mike",
                Salary = 4000,
                Experience = 4
            });empList.Add(new Employee
            {
                ID = 101,
                Name = "John",
                Salary = 6000,
                Experience = 6
            });empList.Add(new Employee
            {
                ID = 101,
                Name = "Todd",
                Salary = 3000,
                Experience = 3
            });

            // Delegates are kinda like Javascript's callback functions.
            Employee.PromoteEmployee(empList, emp => emp.Experience >= 5);
        }        
    }
}
