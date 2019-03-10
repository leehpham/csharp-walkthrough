using System;

namespace MethodOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Add(1, 2, 3);
        }

        public static void Add(int fn, int sn)
        {
            Console.WriteLine("Sum = {0}", fn + sn);
        }

        public static void Add(int fn, int sn, int tn)
        {
            Console.WriteLine("Sum = {0}", fn + sn + tn);
        }

        public static void Add(float fn, float sn)
        {
            Console.WriteLine("Sum = {0}", fn + sn);
        }
    }
}
