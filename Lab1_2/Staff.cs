using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_2
{
    public class Staff
    {
        private StaffMember[] listStaff;
        public Staff()
        {
            listStaff =new StaffMember[3];
            listStaff[0] = new Executive("Sam", "123 Main Line","555-0469", "123-45-6789", 2423.07);
            listStaff[1] = new Employee("Carla", "456 Off Line","555-0101", "987-65-4321", 1246.15);
            listStaff[2] = new Hourly("Woody", "789 Off Rocker","555-0000", "010-20-3040", 10.55);

            ((Executive)listStaff[0]).awardBonus(500.00);        
            ((Hourly)listStaff[2]).addHours(40);
            
        }
        public void payday() {
            double amount;
            for (int i=0; i < listStaff.Count(); i++)
              {
                 Console.WriteLine(listStaff[i].Output());
                 amount =  listStaff[i].pay();  // polymorphic
                 if (amount == 0.0)
                    Console.WriteLine("Thanks!");
                 else
                    Console.WriteLine("Paid: " + amount);
                 Console.WriteLine("-----------------------------------");
              }
   }


    }
}
