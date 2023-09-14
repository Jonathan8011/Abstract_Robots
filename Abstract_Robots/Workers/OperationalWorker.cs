using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_inc
{
    public class OperationalWorker : Worker 
    {
        private double SalaryPerH;
        private double hours;

        public OperationalWorker(string name, string id, DateTime bDate, string pass , int SalaryPerH, double hours)
            : base(name, id, bDate, pass)
        {
            this.SalaryPerH = SalaryPerH;
            this.hours = hours;
        }

        public override double TotalSalary()
        {
            return SalaryPerH * hours;
        }

    }
}
