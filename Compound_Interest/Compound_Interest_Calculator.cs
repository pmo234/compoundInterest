using System;
namespace Compound_Interest
{
    public class Compound_Interest_Calculator
    {
        public static double InterestProductA(
            double initial_amount,
            double interest_rate = 3)
        {
           
            return Math.Round(initial_amount * ((100 + interest_rate) / 100),2);
        }

        public static double InterestProductB(
            int months,
           double initial_amount,
           double interest_rate = 2.95)
        {
            double calculation = initial_amount * Math.Pow((100 + interest_rate) / 100, months);
           
            return Math.Round(calculation,2);
        }
        public static double InterestProductC(
           int months,
          double initial_amount,
          double interest_rate)
        {
            double calculation = initial_amount * Math.Pow((100 + interest_rate) / 100, months);

            return Math.Round(calculation, 2);
        }
       
    }
}

