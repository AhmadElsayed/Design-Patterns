using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DecoratorPattern
{
    public abstract class Beverage
    {
        public string description = "unknown";

        public virtual string GetDescription()
        {
            return description;
        }

        public abstract double Cost();
    }
}
