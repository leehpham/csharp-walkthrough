using System;
using System.Collections.Generic;
using System.Linq;

namespace ArrayToDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer
            {
                ID = 101,
                Name = "Mark",
                Salary = 5000
            };

            Customer customer2 = new Customer
            {
                ID = 110,
                Name = "Pam",
                Salary = 6500
            };

            Customer customer3 = new Customer
            {
                ID = 119,
                Name = "John",
                Salary = 3500
            };

            Customer[] customers = new Customer[3];
            customers[0] = customer1;
            customers[1] = customer2;
            customers[2] = customer3;

            // Convert array to dictionary
            Dictionary<int, Customer> dict = customers.ToDictionary(c => c.ID, c => c);

            foreach (KeyValuePair<int, Customer> kvp in dict)
            {
                Console.WriteLine("Key = {0}", kvp.Key);
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", kvp.Value.ID, kvp.Value.Name, kvp.Value.Salary);
            }

            // Can also convert a list to dictionary the same way
        }
    }

    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
    }
}
