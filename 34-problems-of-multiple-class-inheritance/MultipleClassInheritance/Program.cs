using System;

namespace MultipleClassInheritance
{
    class A
    {
        public virtual void Print()
        {
            Console.WriteLine("A Implementation");
        }
    }

    class B : A
    {
        public override void Print()
        {
            Console.WriteLine("B Implementation");
        }
    }

    class C : A
    {
        public override void Print()
        {
            Console.WriteLine("C Implementation");
        }
    }

    

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
