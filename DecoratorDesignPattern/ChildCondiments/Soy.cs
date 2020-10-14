using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsCore.DecoratorPattern
{
    public class Soy : CondimentDecorator
    {
        Beverage beverage;
        public Soy(Beverage concreteBev)
        {
            beverage = concreteBev;
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", Soy";
        }

        public override double Cost()
        {
            return 0.15 + beverage.Cost();
        }
    }
}
