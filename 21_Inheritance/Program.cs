using System;

namespace _21_Inheritance
{
    // Base class
    public class Employee
    {
        // Make these fields public for now.
        // Not good practice but later on we'll use Properties.
        public string firstName;
        public string lastName;
        public string email;

        public void PrintFullName()
        {
            Console.WriteLine(firstName + " " + lastName);
        }
    }

    // Derived class
    public class FullTimeEmployee : Employee
    {
        public float yearlySalary;
    }

    // Derived class
    public class PartTimeEmployee: Employee
    {
        public float hourlySalary;
    }

    class Program
    {
        static void Main(string[] args)
        {
            FullTimeEmployee FTE = new FullTimeEmployee();
            FTE.firstName = "Hoang";
            FTE.lastName = "Pham";
            FTE.yearlySalary = 500000;
            FTE.PrintFullName();

            PartTimeEmployee PTE = new PartTimeEmployee();
            PTE.firstName = "Part";
            PTE.lastName = "Time";
            PTE.PrintFullName();
        }
    }
}
