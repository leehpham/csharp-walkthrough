using System;

namespace Polymorphism
{
    // Base class
    public class Employee
    {
        public string firstName = "FN";
        public string lastName = "LN";

        // Make this method virtual so derived classes can override it.
        public virtual void PrintFullName()
        {
            Console.WriteLine(firstName + " " + lastName);
        }
    }

    // Derived class
    public class PartTimeEmployee : Employee
    {
        // Override base class' method
        public override void PrintFullName()
        {
            Console.WriteLine(firstName + " " + lastName + " - Part Time");
        }
    }

    // Derived class
    public class FullTimeEmployee : Employee
    {
        // Override base class' method
        public override void PrintFullName()
        {
            Console.WriteLine(firstName + " " + lastName + " - Full Time");
        }
    }

    // Derived class
    public class TemporaryTimeEmployee : Employee
    {
        // Override base class' method
        public override void PrintFullName()
        {
            Console.WriteLine(firstName + " " + lastName + " - Temporary Time");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee[] employees = new Employee[4];

            employees[0] = new Employee();
            employees[1] = new PartTimeEmployee();
            employees[2] = new FullTimeEmployee();
            employees[3] = new TemporaryTimeEmployee();

            foreach (Employee e in employees)
            {
                // Corresponding derived class' method will be called.
                e.PrintFullName();
            }
        }
    }
}
