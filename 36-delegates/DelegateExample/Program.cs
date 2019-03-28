using System;

namespace DelegateExample
{
    public delegate void HelloFunctionDelegate(string message);

    class Program
    {
        static void Main(string[] args)
        {
            // A delegate is a type safe function pointer
            HelloFunctionDelegate myDelegate = new HelloFunctionDelegate(Hello);
            myDelegate("Hello from Delegate");
        }

        public static void Hello(string strMessage)
        {
            Console.WriteLine(strMessage);
        }
    }
}
