using System;

namespace Add_7._3._3_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    abstract class ComputerPart
    {
        public abstract void Work();
    }
    class MotherBoard: ComputerPart
    {
        public override void Work()
        {
            Console.WriteLine("Mother");
        }
    }
    class Processor: ComputerPart
    {
        public override void Work()
        {
            
        }
    }
}
