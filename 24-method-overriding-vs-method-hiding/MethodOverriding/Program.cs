using System;

namespace MethodOverriding
{
    public class BaseClass
    {
        public virtual void Print()
        {
            Console.WriteLine("Base Class Print Method");
        }
    }

    public class DerivedClass : BaseClass
    {
        public override void Print()
        {
            Console.WriteLine("Child Class Print Method");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {            
            BaseClass b = new DerivedClass();
            // The overrding method in the derived class will run
            b.Print();
        }
    }
}
