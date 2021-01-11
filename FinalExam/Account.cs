using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam
{
    abstract class Account
    {
        public string AccountNum { get; set; }

        public string AccountType { get; set; }
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

        public CurrentAccount(string accountype, string accountNum ,string firstName, string lastName, double balance)
        {
            AccountType = accountype;
            AccountNum = accountNum;
            FirstName = firstName;
            LastName = lastName;
            Balance = balance;
            

        }

        public override string ToString()
        {
            return string.Format($"{AccountNum}-{FirstName}-{LastName}");
        }




    }

    class SavingsAccount : Account
    {
        double Interest = 0.06;

        public override double CalculateInterest()
        {
            return Balance * Interest;

        }

        public SavingsAccount(string accountype,string accountNum, string firstName, string lastName, double balance)
        {
            AccountType = accountype;
            AccountNum = accountNum;
            FirstName = firstName;
            LastName = lastName;
            Balance = balance;
            

        }

        public override string ToString()
        {
            return string.Format($"{AccountNum}-{FirstName}-{LastName}");
        }



    }
}
