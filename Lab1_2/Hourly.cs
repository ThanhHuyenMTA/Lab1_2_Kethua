using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_2
{
    class Hourly:Employee
    {
        private int hoursWorked;

        public int HoursWorked
        {
            get { return hoursWorked; }
            set { hoursWorked = value; }
        }

        public Hourly() { }
        public Hourly(string name,string address,string phone,string socialSecurityNumber,double payRate):base(name,address,phone,socialSecurityNumber,payRate)
        {
            this.hoursWorked = 0;
        }
        public void addHours(int moreHours)
        {
            hoursWorked += moreHours;
        }

        override public double pay()
        {
            double payment = PayRate * hoursWorked;
            hoursWorked = 0;
            return payment;
        }

        override public String Output()
        {
            String row = base.Output();
            row += "\nCurrent hours: " + hoursWorked;
            return row;
        }

    }
}
