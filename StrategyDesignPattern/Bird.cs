using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StrategyDesignPattern
{
    public class Bird : Animal
    {
        public Bird()
        {
            SetFlyingType(new CanFly());
        }
    }
}
