namespace _02.StudentsAndWorkers
{
    using System;

    public class Worker : Human
    {
        private decimal weekSalary;
        private double workHours;

        public Worker(string firstName, string lastName, decimal weekSalary, double workHours)
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHours = workHours;
        }

        public decimal WeekSalary
        {
            get
            {
                return this.weekSalary;
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Salary cannot be negative!");
                }

                this.weekSalary = value;
            }
        }

        public double WorkHours
        {
            get
            {
                return this.workHours;
            }

            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Salary cannot be negative!");
                }

                this.workHours = value;
            }
        }

        public decimal MoneyPerHour()
        {
            decimal result = (this.weekSalary / 5) / (decimal)this.workHours;
            return result;
        }

        public override string ToString()
        {
            return string.Format(
                                "Worker: {0} {1}, week Salary: {2}, work Hours: {3}, money per hour: {4:F2}",
                                 this.FirstName.ToString(),
                                 this.LastName.ToString(),
                                 this.weekSalary, 
                                 this.workHours, 
                                 this.MoneyPerHour());
        }
    }
}
