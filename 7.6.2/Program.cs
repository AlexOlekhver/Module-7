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
    abstract class Car<TEngine>
        where TEngine: Engine
    {
        public TEngine Engine;
        public virtual void ChangePart<TPart>(TPart newPart) where TPart : CarPart
        {

        }
    }
    abstract class Engine
    {

    }
    abstract class CarPart
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
    class GasCar
    {

    }
    class ElectricCar
    {

    }
}
