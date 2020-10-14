using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsCore.DecoratorPattern
{
    public class Mocha : CondimentDecorator
    {
        Beverage beverage;
        public Mocha(Beverage concreteBeverage)
        {
            beverage = concreteBeverage;
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", Mocha";
        }

        public override double Cost()
        {
            return 0.20 + beverage.Cost();
        }
    }
}
