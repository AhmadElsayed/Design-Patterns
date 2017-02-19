using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StrategyDesignPattern
{
    // The base class
    public class Animal
    {
        IFly _flyingType;

        protected void SetFlyingType(IFly flyingType)
        {
            this._flyingType = flyingType;
        }

        public void TryToFly()
        {
            this._flyingType.Fly();
        }
    }
}
