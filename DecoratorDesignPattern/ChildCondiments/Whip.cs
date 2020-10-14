using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsCore.DecoratorPattern
{
    public class Whip : CondimentDecorator
    {
        Beverage beverage;
        public Whip(Beverage concreteBev)
        {
            beverage = concreteBev;
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", Whip";
        }

        public override double Cost()
        {
            return 0.10 + beverage.Cost();
        }
    }
}
