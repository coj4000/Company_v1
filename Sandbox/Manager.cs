using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sandbox
{
    class Manager : Employee
    {
        protected int monthlyBonus;
        protected int workhrs;
        public Manager(string name, int salaryPerMonth, int monthlyBonus, int workhrs) : base(name, salaryPerMonth)
        {
            this.monthlyBonus = monthlyBonus;
            this.workhrs = workhrs;
        }

        public override int GetSalaryPerMonth()
        {
            int salary = base.GetSalaryPerMonth();
            if (workhrs >= 180)
            {
                salary = salary + monthlyBonus;
            }
            return salary;
        }
    }
}
