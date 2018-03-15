using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_2
{
    class Employee : StaffMember
    {
        private String socialSecurityNumber;

        public String SocialSecurityNumber
        {
            get { return socialSecurityNumber; }
            set { socialSecurityNumber = value; }
        }
        private double payRate;

        public double PayRate
        {
            get { return payRate; }
            set { payRate = value; }
        }
        public Employee() { }
        public Employee(string name, string address, string phone, string socialSecurityNumber, double payRate)
            : base(name, address, phone)
        {
            this.socialSecurityNumber = socialSecurityNumber;
            this.payRate = payRate;
        }
        override public String Output()
        {
            String row =base.Output() + "\nSocial Security Number: " + socialSecurityNumber;
            return row;
        }
        override public double pay()
        {
            return payRate;
        }

    }
}
