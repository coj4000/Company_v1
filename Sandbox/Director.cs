using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sandbox
{
    class Director : Manager
    {
       
        public Director(string name, int salaryPerMonth, int monthlyBonus, int workhrs)
            : base(name, salaryPerMonth, monthlyBonus, workhrs)
        {
        }

        public override int GetSalaryPerMonth()
        {
            int salary = base.GetSalaryPerMonth() + 20000;
            return salary;
        }
    }
}
