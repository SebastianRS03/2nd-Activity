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
        public int KeyCode
        {
            get { return this.keyCode; }
            set
            {
                this.keyCode = value;
            }
        }
        private DateOnly initialDate;
        public DateOnly InitialDate
        {
            get { return this.initialDate; }
            set
            {
                this.initialDate = value;
            }
        }
        private DateOnly expirationDate;
        public DateOnly ExpirationDate
        {
            get { return this.expirationDate; }
            set
            {
                this.expirationDate = value;
            }
        }
        private Boolean status;
        public Boolean Status
        {
            get { return this.status; }
            set
            {
                this.status = value;
            }
        }
        private string type;
        public string Type
        {
            get { return this.type; }
            set
            {
                this.type = value;
            }
        }

        public License(Person person, Vehicle vehicle)
        {
            this.status = applyLicense(person, vehicle);
            DateTime dateTime1 = DateTime.Now;
            DateOnly initialDate = DateOnly.FromDateTime(dateTime1);
            DateTime dateTime2 = DateTime.Now.AddYears(5);
            DateOnly expirationDate = DateOnly.FromDateTime(dateTime2);
            this.keyCode = person.KeyCode;
            this.initialDate = initialDate;
            this.expirationDate = expirationDate;
            this.type = vehicle.Type;
            
        }
        public Boolean applyLicense(Person person, Vehicle vehicle)
        {
            if (vehicle.Valid == true)
            {
                if (person.Age > 90)
                {
                    Console.WriteLine("You're over 90 years old. You cannot be granted a license.");
                    return false;
                }
                return true;
            }
            return false;
        }
        public void expiration(License license, Person person)
        {
            DateTime dateTime = DateTime.Now;
            DateOnly today = DateOnly.FromDateTime(dateTime);
                if (today > license.expirationDate)
            {
                Console.WriteLine("Your license is expired. Please update it as soon as possible.");
                this.status = false;
                person.Licenses.Remove(license);
                
            }
            Console.WriteLine("Your license is still not expired.");

        }

        public void showLicense()
        {
            Console.WriteLine("Key code: " + this.keyCode);
            Console.WriteLine("Type: " + this.type);
            Console.WriteLine("Status: " + this.status);
            Console.WriteLine("Initial date: " + this.initialDate);
            Console.WriteLine("Expiration date: " + this.expirationDate);
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        }
    }
}
