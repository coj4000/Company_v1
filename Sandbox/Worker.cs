using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sandbox
{
    class Worker : Employee
    {
        protected string skill;
        public Worker(string name, int salaryPerMonth, string skill) : base(name, salaryPerMonth)
        {
        }
    }
}
