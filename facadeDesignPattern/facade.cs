using System;
using DesignPatterns.facadeDesignPattern;
using DesignPatterns.Shared;

namespace DesignPatterns
{
    /// <summary>
    /// We have a specifi cycle with multiple steps, Instead of defining all object more and more and check conditions and steps each time
    /// Make One Class that combines all of these together and call once!
    /// Can't be simpler.
    /// It's a facade, so it should always start with small letter, don't know why :D
    /// </summary>
    internal class facade : IPattern
    {
        public void Test()
        {
            Mortgage mortgage = new Mortgage();
            Customer cust = new Customer("Mohsen");

            Console.WriteLine("The Customer Mohsen eligibility is " + mortgage.IsEligible(cust, 3000));
        }
    }
    
}
