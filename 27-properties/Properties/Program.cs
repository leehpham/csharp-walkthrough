using System;

namespace Properties
{
    public class Student
    {
        // If you want extra logics in setter and getter methods, you have to declare a private field and perform the logics in its property.
        private int _id;
        private string _name;

        // _id field property
        public int Id
        {
            set
            {
                // value is the value being used to set the Id property
                if (value <= 0)
                {
                    throw new Exception("Student Id cannot be negative");
                }
                this._id = value;
            }
            get
            {
                return this._id;
            }
        }

        // _name field property
        public string Name
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Name cannot be null or empty");
                }
                this._name = value;
            }
            get
            {
                return string.IsNullOrEmpty(this._name) ? "No Name" : this._name;
            }
        }

        // Auto implemented properties
        
        // Make _passMark field read-only by not providing a Set method
        // Also set 35 as its default value.
        public int PassMark { get; } = 35;

        public string Email { get; set; }
        public string City { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student c1 = new Student();
            c1.Id = 101;
            c1.Name = "Hoang";

            Console.WriteLine("Student Id: {0}", c1.Id);
            Console.WriteLine("Student Name: {0}", c1.Name);
            Console.WriteLine("Student Pass Mark: {0}", c1.PassMark);
        }
    }
}
