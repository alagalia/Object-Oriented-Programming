using System;

namespace _01HumanStudentWorker
{
    class Worker :Human
    {
        private double weekSalary;
        private double workHourPerDay;

        public Worker(string firstName, string lastName, double weekSalary, double workHourPerDay) : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHourPerDay = workHourPerDay;
        }

        public double WeekSalary
        {
            get { return this.weekSalary; }
            set { this.weekSalary = value; }
        }

        public double WorkHourPerDay
        {
            get { return this.workHourPerDay; }
            set { this.workHourPerDay = value; }
        }

        internal double MoneyPerHour()
        {
            double moneyPerHour = this.WeekSalary/(this.WorkHourPerDay*5);
            return moneyPerHour;
        }

        public override string ToString()
        {
            return String.Format("0, week salary:{1}, work hour per day:{2}, money per hour:{3}",base.ToString(), WeekSalary, WorkHourPerDay, this.MoneyPerHour());
        }
    }
}
