using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StrategyDesignPattern
{
    class Dog : Animal
    {
        public Dog()
        {
            SetFlyingType(new CantFly());
        }
    }
}
