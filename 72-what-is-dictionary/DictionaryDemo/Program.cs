using System;
using System.Collections.Generic;
using System.Linq;

namespace DictionaryDemo
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

            // Declare a dictionary.
            Dictionary<int, Customer> customerById = new Dictionary<int, Customer>();

            // Add entries to dictionary
            customerById.Add(customer1.ID, customer1);
            customerById.Add(customer2.ID, customer2);
            customerById.Add(customer3.ID, customer3);

            // Get value using key.
            Customer customer119 = customerById[119];
            Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", customer119.ID, customer119.Name, customer119.Salary);

            // Loop through dictionary
            // Can replace KeyValuePari<int, Customer> to var
            foreach (KeyValuePair<int, Customer> customerKeyValuePair in customerById)
            {
                // Get the Key
                int id = customerKeyValuePair.Key;
                Console.WriteLine("ID = {0}", id);

                // Get the Value
                Customer cust = customerKeyValuePair.Value;
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", cust.ID, cust.Name, cust.Salary);

                Console.WriteLine("---------------------------------------------");
            }

            // Loop through the Keys in dictionary
            foreach (int key in customerById.Keys)
            {
                Console.WriteLine(key);
            }

            // Loop through the Values in dictionary
            foreach (Customer value in customerById.Values)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", value.ID, value.Name, value.Salary);

                Console.WriteLine("---------------------------------------------");
            }

            // Check for availability of a key.
            Customer foo = customerById.ContainsKey(135) ? customerById[135] : new Customer();

            // TryGetValue()
            Customer custTryGetValue;
            if (customerById.TryGetValue(102, out custTryGetValue))
            {
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", custTryGetValue.ID, custTryGetValue.Name, custTryGetValue.Salary);
            }
            else
            {
                Console.WriteLine("The key is not found");
            }

            // Count property
            Console.WriteLine("Total Items = {0}", customerById.Count);
            // Or Count() from LINQ
            Console.WriteLine("Total Items = {0}", customerById.Count(cbi => cbi.Value.Salary > 4000));

            // Remove()
            customerById.Remove(999);

            // Clear(): Remove everything.
            customerById.Clear();
        }
    }

    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
    }
}
