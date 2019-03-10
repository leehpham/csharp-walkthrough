using System;

namespace GetterAndSetter
{
    public class Student
    {
        private int _id;
        private string _name;
        private int _passMark = 35;

        // Use Getter and Setter methods for better control over _id field.
        public void SetId(int id)
        {
            if (id <= 0)
            {
                throw new Exception("Student Id should be greater than zero");
            }
            this._id = id;
        }
        public int GetId()
        {
            return _id;
        }

        // Same for _name field
        public void SetName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new Exception("Name cannot be null or empty");
            }
            this._name = name;
        }
        public string GetName()
        {
            return string.IsNullOrEmpty(this._name) ? "No Name" : this._name;
        }

        // Make _passMark field read-only by not providing a Set method
        public int GetPassMark()
        {
            return this._passMark;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student c1 = new Student();
            c1.SetId(10);
            c1.SetName("Hoang");

            Console.WriteLine("Student Id = {0}", c1.GetId());
            Console.WriteLine("Student Name = {0}", c1.GetName());
            Console.WriteLine("Student Pass Mark = {0}", c1.GetPassMark());

        }
    }
}
