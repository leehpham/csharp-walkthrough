using System;

namespace Structs
{
    public struct Customer
    {
        private int id;
        private string name;

        // Auto implemented properties could be used here.
        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }
        
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        // Constructor
        public Customer(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public void PrintDetails()
        {
            Console.WriteLine("Id = {0} && Name = {1}", this.id, this.name);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer(101, "Hoang");
            c1.PrintDetails();

            Customer c2 = new Customer();
            c2.Id = 102;
            c2.Name = "John";
            c2.PrintDetails();

            // Object initializer syntax to initialize properties directly
            Customer c3 = new Customer
            {
                Id = 103,
                Name = "Rob"
            };
            c3.PrintDetails();        
        }
    }
}
