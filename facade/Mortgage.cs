using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.facade
{
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
