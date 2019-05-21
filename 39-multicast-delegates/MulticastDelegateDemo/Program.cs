using System;

namespace MulticastDelegateDemo
{
    // Declare the delegate
    public delegate void SampleDelegate();

    class Program
    {
        static void Main(string[] args)
        {
            // Create the delegates.
            SampleDelegate del1, del2, del3, del4;
            del1 = new SampleDelegate(SampleMethodOne);
            del2 = new SampleDelegate(SampleMethodTwo);
            del3 = new SampleDelegate(SampleMethodThree);

            // Create the multicast delegate.
            del4 = del1 + del2 + del3 - del2;

            del4();

            Console.WriteLine();

            // We can use += <method_name> to register a method to a delegate.
            // and -= <method_name> to un-register a method.
            SampleDelegate del = new SampleDelegate(SampleMethodOne);
            del += SampleMethodTwo;
            del += SampleMethodThree;
            del -= SampleMethodOne;

            del();
        }

        public static int SampleMethodOne()
        {
            return 1;
        }

        public static void SampleMethodTwo()
        {
            return 2;
        }

        public static void SampleMethodThree()
        {
            Console.WriteLine("SampleMethodThree Invoked");
        }
    }
}
