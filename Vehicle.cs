using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2nd_Activity
{
    internal class Vehicle
    {
        private string type;
        public string Type
        {
            get { return this.type; }
            set
            {
                this.type = value;
            }
        }
        private int year;
        public int Year
        {
            get { return this.year; }
            set
            {
                this.year = value;
            }
        }
        private string brand;
        public string Brand
        {
            get { return this.brand; }
            set
            {
                this.brand = value;
            }
        }
        private string description;
        public string Description
        {
            get { return this.description; }
            set
            {
                this.description = value;
            }
        }
        private int wheels;
        public int Wheels
        {
            get { return this.wheels; }
            set
            {
                this.wheels = value;
            }
        }
        private string color;
        public string Color
        {
            get { return this.color; }
            set
            {
                this.color = value;
            }
        }
        private Boolean valid;
        public Boolean Valid
        {
            get { return this.valid; }
            set
            {
                this.valid = value;
            }
        }

        public Vehicle(string type, int year, string brand, string description, int wheels, string color)
        {
            this.type = type;
            this.year = year;
            this.brand = brand;
            this.description = description;
            this.wheels = wheels;
            this.color = color;
            this.valid = false;
        }

        public void showVehicle()
        {
            Console.WriteLine("Type: " + this.type);
            Console.WriteLine("Brand: " + this.brand);
            Console.WriteLine("Year: " + this.year);
            Console.WriteLine("Color: " + this.color);
            Console.WriteLine("Wheels: " + this.wheels);
            Console.WriteLine("Description: " + this.description);
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        }
    }
}
