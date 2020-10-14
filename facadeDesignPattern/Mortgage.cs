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
    public class Mortgage
    {
        private Bank _bank;
        private Loan _loan;
        private Credit _credit;

        public Mortgage()
        {
            _bank = new Bank();
            _loan = new Loan();
            _credit = new Credit();
        }

        /// <summary>
        /// Check all conditions on all classes and return a conclusion status
        /// </summary>
        /// <returns>Eligibility</returns>
        public bool IsEligible(Customer cust, int amount)
        {
            Console.WriteLine("{0} applies for {1:C} loan\n", cust.Name, amount);

            bool eligible = true;

            // Check creditworthyness of applicant
            if (!_bank.HasSufficientSavings(cust, amount))
            {
                eligible = false;
            }
            else if (!_loan.HasNoBadLoans(cust))
            {
                eligible = false;
            }
            else if (!_credit.HasGoodCredit(cust))
            {
                eligible = false;
            }

            return eligible;

        }
    }
}
