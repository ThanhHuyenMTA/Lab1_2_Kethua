using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_2
{
    class Executive:Employee
    {
        private double bonus;

        public double Bonus
        {
            get { return bonus; }
            set { bonus = value; }
        }
        public Executive() { }
        public Executive(string name, string address, string phone, string socialSecurityNumber, double payRate): base(name, address, phone,socialSecurityNumber,payRate)
        {
            bonus = 0;
        }
        public void awardBonus(double execBonus)
        {
            bonus = execBonus;
        }
        override public double pay()
        {
            double payment = base.pay() +bonus;
            bonus = 0;
            return payment;
        }

    }
}
