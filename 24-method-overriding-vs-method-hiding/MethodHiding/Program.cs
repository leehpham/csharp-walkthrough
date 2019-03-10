using System;

namespace MethodHiding
{
    public class BaseClass
    {
        public virtual void Print()
        {
            Console.WriteLine("Base Class Print Method.");
        }
    }

    public class DerivedClass : BaseClass
    {
        public new void Print()
        {
            Console.WriteLine("Child Class Print Method.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            BaseClass b = new DerivedClass();
            b.Print();
        }
    }
}
