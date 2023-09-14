using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Robots_inc
{
    public abstract class Worker
    {
        private string fullName;
        private string idNumber;
        private DateTime birthDate;
        private string password;

        //פעולה בונה
        public Worker(string name, string id, DateTime bDate, string pass)
        {
            
            this.fullName = name;
            this.idNumber = id;
            this.birthDate = bDate;
            this.password = pass;
        }

        //פעולות get , set
        public string FullName { get { return fullName; } set { fullName = value; } }
        public string IdNumber { get { return idNumber; } set { idNumber = value; } }
        public DateTime BirthDate { get { return birthDate; } set { birthDate = value; } }
        public string Password { get { return password; } set { password = value; } }

        //פעולה abstract לחישוב שכר
        public abstract double TotalSalary();

        public override string ToString()
        {
            string str = "";
            if(birthDate.Equals(DateTime.Today))
                str=" - HappyBirthDay";
            return fullName + " ID." + idNumber + str;

        }



    }
}
