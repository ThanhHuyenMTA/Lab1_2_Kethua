using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_2
{
    public class Volunteer : StaffMember
    {
        public Volunteer(String name, String address, string phone): base(name, address, phone)
        {
        }

        override public double pay()
        {
            return 0.0;
        }

    }
}
