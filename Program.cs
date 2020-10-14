using System;

namespace DesignPatternsCore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=======================Strategy=====================");
            IPattern generator = new Strategy();
            //generator.Test();

            Console.WriteLine("=======================Observer=====================");
            generator = new Observer();
            //generator.Test();

            Console.WriteLine("=======================Factory=====================");
            generator = new Factory();
            //generator.Test();

            Console.WriteLine("=======================facade=====================");
            generator = new facade();
            generator.Test();

            Console.WriteLine("=======================Adapter=====================");
            generator = new Adapter();
            //generator.Test();

            Console.WriteLine("=======================Decorator=====================");
            generator = new Decorator();
            // generator.Test();

            Console.WriteLine("=======================Mediator=====================");
            generator = new MediatorRunner();
            //generator.Test();

            Console.ReadLine();
        }
    }
}
