using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam
{
    abstract class Account
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public double Balance { get; set; }

        public double InterestDate { get; set; }

        public virtual double Deposit()
        {
            return 1 * 2;
        }

        public virtual double Withdraw()
        {
            return 1 * 2;
        }

        public abstract double CalculateInterest();
    }
    class CurrentAccount : Account
    {
        double Interest = 0.03;

        public override double CalculateInterest()
        {
            return Balance * Interest;
    
        }




    }

    class SavingsAccount : Account
    {
        double Interest = 0.06;

        public override double CalculateInterest()
        {
            return Balance * Interest;

        }



    }
}
