using DesignPatternsCore.DecoratorPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsCore
{
    internal class Decorator : IPattern
    {
        /// <summary>
        /// # Motivation 
        /// I can now attach responsibilities to an object dynamically to add behaviour at runtime.
        /// 
        /// # Structure
        /// Beverage
        ///  --> base class so all objects are of same type
        /// CondimentDecorator : Bevarage
        ///  --> interchangeable with Beverage
        ///  
        /// # Sample Problem
        /// A coffee shop wants to make an ordering system for all their drinks. Ofcourse there are a lot of combination with condiments/roasts.
        /// We could create a base class and let all possible combinations inherit from the superclass and override their behaviour, but that would quickly become a mess.
        /// 
        /// # Solution
        /// By creating a Decorator class which inherits from the baseclass (to effectively swap between types), I can now dynamically create composite objects at runtime.
        /// To add a drink to the system:
        ///     1. inherit from the base class, set instance fields in constructor
        ///     2. override the 'Cost()' method to return desired cost
        /// To add a condiment to the system:
        ///     1. inherit from 'CondimentDecorator' (indirectly from base class as well
        ///     2. add instance field from type Beverage
        ///     3. initialize in constructor
        ///     4. override GetDescription() and Cost() accordingly
        /// To create a composite object at runtime:
        ///     1. Create a new instance of a drink (Beverage)
        ///     2. To add a condiment, assign the instance to a new instance of the condiment with itself as param
        ///         A. Beverage darkRoast = new DarkRoast();
        ///         B. darkRoast = new Mocha(darkRoast);
        /// </summary>
        public void Test()
        {
            Beverage beverage = new Espresso();
            Console.WriteLine($"{beverage.GetDescription()} ${beverage.Cost()}");

            Beverage beverage1 = new DarkRoast();
            beverage1 = new Mocha(beverage1);
            Console.WriteLine($"{beverage1.GetDescription()} ${beverage1.Cost()}");

            Beverage beverage2 = new DarkRoast();
            beverage2 = new Mocha(beverage2);
            Console.WriteLine($"{beverage2.GetDescription()} ${beverage2.Cost()}");
            beverage2 = new Mocha(beverage2);
            Console.WriteLine($"{beverage2.GetDescription()} ${beverage2.Cost()}");
            beverage2 = new Whip(beverage2);
            Console.WriteLine($"{beverage2.GetDescription()} ${beverage2.Cost()}");

            Beverage beverage3 = new HouseBlend();
            beverage3 = new Soy(beverage3);
            beverage3 = new Mocha(beverage3);
            beverage3 = new Whip(beverage3);
            
            Console.WriteLine($"{beverage3.GetDescription()} ${beverage3.Cost()}");
        }
    }
}
