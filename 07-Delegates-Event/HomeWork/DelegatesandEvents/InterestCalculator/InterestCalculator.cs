using System;

namespace InterestCalculator
{
    public delegate decimal CalculateInterestDelegate(decimal sumMoney, decimal interest, int years);

    public class InterestCalculator
    {
        private decimal sumMoney;
        private decimal interest;
        private int years;

        public InterestCalculator(decimal sumMoney, decimal interest, int years, CalculateInterestDelegate delegat)
        {
            this.SumMoney = sumMoney;
            this.Interest = interest;
            this.Years = years;
            this.TotalSum = delegat(sumMoney, interest, years);
        }

        public decimal SumMoney 
        {
            get { return this.sumMoney; }
            set
            {
                if (value <0)
                {
                    throw  new ArgumentOutOfRangeException("value","Sum cannot take negative value");
                }
                this.sumMoney=value;
            }
        }
        public decimal Interest
        {
            get { return this.interest; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("value", "Interest cannot take negative value");
                }
                this.interest = value;
            }
        }
        public int Years
        {
            get
            {
                return this.years;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("value", "Years cannot take negative value");
                }
            }
        }
        public decimal TotalSum { get; set; }

        
        public override string ToString()
        {
            return string.Format("Money: {0}, Interest: {1}%, Years: {2}, Result: {3:F4}", this.SumMoney, this.Interest, this.Years, this.TotalSum);
        }
    }
}
