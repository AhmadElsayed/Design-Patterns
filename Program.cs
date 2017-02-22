using System;
using DesignPatterns.Shared;

namespace DesignPatterns
{
    
    internal class Program
    {
        private static void Main(string[] args)
        {

            Console.WriteLine("=======================Strategy=====================");
            IPattern generator = new Strategy();
            generator.Test();

            Console.WriteLine("=======================Observer=====================");
            generator = new Observer();
            generator.Test();

            Console.WriteLine("=======================Factory=====================");
            generator = new Factory();
            generator.Test();

            Console.WriteLine("=======================facade=====================");
            generator = new facade();
            generator.Test();

            Console.ReadLine();
        }
       
    }
}
