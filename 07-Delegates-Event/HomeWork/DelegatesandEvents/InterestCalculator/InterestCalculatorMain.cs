using System;

namespace InterestCalculator
{
    class InterestCalculatorMain
    {
        private const int InterestCompounded = 12;

        private static decimal GetSimpleInterestMethod(decimal sumMoney, decimal interest, int years)
        {
            return sumMoney * (1 +interest / 100 * years);
        }

        private static decimal GetCompoundInterestMethod(decimal sumMoney, decimal interest, int years)
        {
            return sumMoney * (decimal)Math.Pow((double)(1 + (interest / 100 / InterestCompounded)), years * InterestCompounded);
        }

        static void Main(string[] args)
        {
            CalculateInterestDelegate simple = GetSimpleInterestMethod;
            CalculateInterestDelegate compound = GetCompoundInterestMethod;

            var simpleResult = new InterestCalculator(2500m, 7.2m, 15, simple);
            var compoundResult = new InterestCalculator(500m, 5.6m, 10, compound);
            Console.WriteLine(simpleResult);
            Console.WriteLine(compoundResult);
        }
    }

}
