using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_inc
{
    public class OperationManager : Worker
    {
        private double SalaryPerH;
        private double hours;
        private int NumOfMissionSucceed;

        public OperationManager(string name, string id, DateTime bDate, string pass, double SalaryPerH , double hours , int NumOfMissionSucceed)
            : base(name, id, bDate, pass)
        {
            this.SalaryPerH = SalaryPerH;
            this.hours = hours;
        }

        public override double TotalSalary()
        {
            double totalSalary = SalaryPerH * hours;
            for (int i = 0; i < NumOfMissionSucceed; i++)
            {
                totalSalary +=  totalSalary*0.03; // מוסיף 3% כל הצלחה
            }
            return totalSalary;
        }

    }
}
