using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StrategyDesignPattern
{
    /// <summary>
    /// #Motivation
    /// By this pattern i can have a single parent with all the properties and methods shared, but handle
    /// a specific event by two different ways
    /// 
    /// #Structure
    ///                       --- Bird() : SetFlyingType(new IFly::CanFly())
    ///                     /
    /// (base class) Animal
    ///                     \
    ///                       --- Dog() : SetFlyingType(new IFly::CantFly())
    /// 
    /// #Sample Problem
    /// I have a base class animal that will implement all sepcies and types
    /// But the problem is that all species handles the flying events by two main ways instead of one
    ///     - Those who can fly
    ///     - Those who can not fly
    /// 
    /// #Solution
    ///     1. Create an Interface that will be responsible for handling the Odd behavior
    ///     2. Add object from this interface in the base class
    ///     3. Implement the interface multiple times by the each possible handling way
    ///     4. In the constructor of each implementations of the main Class (which is animal in our sample)
    ///        Initialize the object i have created (in step2) with the suitable handle way
    /// 
    /// </summary>
    public class Bird : Animal
    {
        /// <summary>
        /// All animals that will handle the flying event by this way should do the same in constructor
        /// </summary>
        public Bird()
        {
            SetFlyingType(new CanFly());
        }
    }
}
