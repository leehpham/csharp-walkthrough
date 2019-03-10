using System;

namespace Interface
{
    interface ICustomer1
    {
        void Print1();
    }

    interface ICustomer2 : ICustomer1
    {
        void Print2();
    }

    public class Customer : ICustomer2
    {
        public void Print1()
        {
            Console.WriteLine("Print1");
        }

        public void Print2()
        {
            Console.WriteLine("Print2");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ICustomer1 cust = new Customer();
            cust.Print1();
        }
    }
}
