using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2nd_Activity
{
    internal class License
    {
        private int keyCode;
        private DateOnly initialDate;
        private DateOnly expirationDate;
        private Boolean status;
        private string type;

        public License(DateOnly initialDate, DateOnly expirationDate, bool status, string type, Person person, Vehicle vehicle)
        {
            this.keyCode = person.getKeyCode();
            this.initialDate = initialDate;
            this.expirationDate = expirationDate;
            this.status = status;
            this.type = vehicle.getType();
        }
        public Boolean getStatus()
        {
            return this.status;
        }
        public Boolean applyLicense(Person person, Vehicle vehicle)
        {
            string type = vehicle.getType();
            if (person.getAge() > 90)
            {
                Console.WriteLine("You're over 90 years old. You cannot be granted a license.");
                return false;
            }
            for (int i = 0; i < person.getLicenseCounter(); i++)
            {
                if (person.getLicenses().[i] == type)
                {
                    Console.WriteLine("You already have a license of that type.");
                    return false;
                }
            }
            Console.WriteLine("All your data is in order. The license will be granted.");
            return true;
        }
    }
}
