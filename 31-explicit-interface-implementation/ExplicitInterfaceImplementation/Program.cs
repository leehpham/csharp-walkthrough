using System;

namespace ExplicitInterfaceImplementation
{
    interface I1
    {
        void InterfaceMethod();
    }

    interface I2
    {
        void InterfaceMethod();
    }

    class Program : I1, I2
    {
        // The class explicitly implements I1 method
        void I1.InterfaceMethod()
        {
            Console.WriteLine("I1 Interface Method");
        }

        // The class explicitly implements I2 method
        void I2.InterfaceMethod()
        {
            Console.WriteLine("I2 Interface Method");
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            // Typecast object to interface to call interface method.
            ((I1)p).InterfaceMethod();
            ((I2)p).InterfaceMethod();

            // OR
            I1 i1 = new Program();
            i1.InterfaceMethod();
            I2 i2 = new Program();
            i2.InterfaceMethod();
        }
    }
}
