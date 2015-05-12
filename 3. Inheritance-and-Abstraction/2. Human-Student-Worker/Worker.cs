using System;

namespace _2.Human_Student_Worker
{
    class Worker : Human
    {
        public double WeekSalary { get; set; }
        public double WorkHoursPerDay { get; set; }

        public Worker(string firstName, string lastName, double weekSalary, double workHoursPerDay) : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }
        public double MoneyPerHour(double weekSalary, double workHoursPerDay)
        {
            double money = WeekSalary / 5 / WorkHoursPerDay;
            return money;
        }

        public override string ToString()
        {
            return String.Format("First name: {0}, Last name: {1}, Week salary: {2}, Work hours per day: {3}", FirstName, LastName, WeekSalary, WorkHoursPerDay);
        }
    }
}
