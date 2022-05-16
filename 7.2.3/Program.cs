using System;

namespace _7._2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

}
class BaseClass
{
    public virtual void Display()
    {
        Console.WriteLine("Method of class BaseClass");
    }
}
class DerivedClass: BaseClass
{
    public override void Display()
    {
        Console.WriteLine("Method of class DerivedClass");
    }
}