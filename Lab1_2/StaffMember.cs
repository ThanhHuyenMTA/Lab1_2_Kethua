using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_2
{
    abstract public class StaffMember
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string address;
        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        private string phone;
        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        public StaffMember(){}
        public StaffMember(string name,string address,string phone)
        {
            this.name = name;
            this.address = address;
            this.phone = phone;
        }

        virtual public String Output()
        {
            String row = "Name: " + name + "\n";
            row += "Address: " + address + "\n";
            row += "Phone: " + phone;
            return row;
        }
        public abstract double pay();

    }
}
