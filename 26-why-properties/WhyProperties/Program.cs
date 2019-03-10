using System;

namespace WhyProperties
{
    public class Student
    {
        public int id;
        public string name;
        public int passMark = 35;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student c1 = new Student();

            // Unexpected values can be set here!
            c1.id = -101;
            c1.name = null;
            c1.passMark = 0;

            // Unexpected output!
            Console.WriteLine("ID = {0} && Name = {1} && PassMark = {2}", c1.id, c1.name, c1.passMark);
        }
    }
}
