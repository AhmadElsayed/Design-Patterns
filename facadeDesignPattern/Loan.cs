using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsCore.facadeDesignPattern
{
    /// <summary>
    /// We have a specifi cycle with multiple steps, Instead of defining all object more and more and check conditions and steps each time
    /// Make One Class that combines all of these together and call once!
    /// Can't be simpler.
    /// It's a facade, so it should always start with small letter, don't know why :D
    /// </summary>
    public class Loan
    {
        public bool HasNoBadLoans(Customer c)
        {
            Console.WriteLine("Check loans for " + c.Name);
            return true;
        }
    }
}
