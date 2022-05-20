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
        where T: Engine
        {
        public T Engine;
        public virtual void ChangePart<T1>(T1 newPart) where T1: CarPart
        {

        }
    }
    class Engine
    {

    }
    class CarPart
    {

    }
    class ElectricEngine: Engine
    {

    }
    class GasEngine: Engine
    {

    }
    class Battery: CarPart
    {

    }
    class Differential : CarPart
    {

    }
    class Wheel : CarPart
    {

    }
}
