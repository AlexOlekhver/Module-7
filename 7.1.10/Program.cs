using System;

namespace _7._1._10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    class BaseClass
    {
        protected string Name;

        public BaseClass(string name)
        {
            Name = name;
        }
    }

    class DerivedClass : BaseClass
    {
        public string Description;

        public int Counter;

        public DerivedClass(string Name, string Description) : base(Name)
        {

        }
        public DerivedClass(string Name, string Description, int counter) : base(Name)
        {

        }
    }
}
