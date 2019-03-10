using System;

namespace MethodHiding
{
    public class Employee
    {
        public string firstName;
        public string lastName;

        public void PrintFullName()
        {
            Console.WriteLine(firstName + " " + lastName);
        }
    }

    public class PartTimeEmployee : Employee
    {
        // This method hides the parent class' method
        public new void PrintFullName()
        {
            // Call the parent class' method using "base" keyword
            base.PrintFullName();
            Console.WriteLine(firstName + " " + lastName + " - Contractor");
        }
    }

    public class FullTimeEmployee : Employee
    {
        
    }

    class Program
    {
        static void Main(string[] args)
        {
            FullTimeEmployee FTE = new FullTimeEmployee();
            FTE.firstName = "FullTime";
            FTE.lastName = "Employee";
            FTE.PrintFullName();

            PartTimeEmployee PTE = new PartTimeEmployee();
            PTE.firstName = "PartTime";
            PTE.lastName = "Employee";
            PTE.PrintFullName();

            // Can typecast the derived class to base class.
            // Now the base class' method is called.
            ((Employee)PTE).PrintFullName();

            // This is possible (think bigger smaller object)
            Employee PTENew = new PartTimeEmployee();
            // Base class' method is called
            PTENew.PrintFullName();

            // This is impossible (think bigger smaller objects)
            // PartTimeEmployee PTENew02 = new Employee();
        }
    }
}
