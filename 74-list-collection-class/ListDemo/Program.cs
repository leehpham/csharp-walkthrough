using System;
using System.Collections.Generic;

namespace ListDemo
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

            List<Customer> customers = new List<Customer>(2);
            customers.Add(customer1);
            customers.Add(customer2);
            customers.Add(customer3);

            // Insert an element to list
            customers.Insert(0, customer3);

            // Loop through list
            foreach (Customer c in customers)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", c.ID, c.Name, c.Salary);
            }

            for (int i = 0; i < customers.Count; i++)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", customers[i].ID, customers[i].Name, customers[i].Salary);

            }

            // Get index of an element
            Console.WriteLine(customers.IndexOf(customer3));

        }
    }

    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
    }

    public class SavingsCustomer : Customer
    {

    }
}
