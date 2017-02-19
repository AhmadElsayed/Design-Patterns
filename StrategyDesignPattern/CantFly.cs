using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StrategyDesignPattern
{
    public class CantFly : IFly
    {
        public void Fly()
        {
            Console.WriteLine("I Can Not Fly");
        }
    }
}
