using System;

namespace _7._6._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    class Car<T>
    {
        public T Engine;
        public virtual void ChangePart<T>(T newPart)
        {

        }
    }
    class ElectricEngine
    {

    }
    class GasEngine
    {

    }
    class Battery
    {

    }
    class Differential
    {

    }
    class Wheel
    {

    }
}
