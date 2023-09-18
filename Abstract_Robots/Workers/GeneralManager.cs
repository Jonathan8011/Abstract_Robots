using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_inc
{
    public class GeneralManager : Worker
    {
        private double monthlySalary;
        private int workingRobots;

        public GeneralManager(string name, string id, DateTime bDate, string passW, double monthlySalary , int workingRobots)
            :base (name,id,bDate,passW)
        {
            this.monthlySalary = monthlySalary;
            this.workingRobots = workingRobots;
        }

        public override double TotalSalary()
        {
            if (workingRobots > 30) 
                return monthlySalary + monthlySalary * 0.3; // מוסיף בונוס של 30%
            return monthlySalary;
        }


    }
}
