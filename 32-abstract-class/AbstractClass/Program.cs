using System;

namespace AbstractClass
{
    public abstract class Customer
    {
        public void Print()
        {
            Console.WriteLine("Print");
        }
    }

    public class Program : Customer
    {        
        static void Main(string[] args)
        {
            
        }
    }
}
