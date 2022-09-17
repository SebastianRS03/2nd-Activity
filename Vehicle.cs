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
        private int year;
        private string brand;
        private string description;
        private int wheels;
        private string color;

        public Vehicle(string type, int year, string brand, string description, int wheels, string color)
        {
            this.type = type;
            this.year = year;
            this.brand = brand;
            this.description = description;
            this.wheels = wheels;
            this.color = color;
        }

        public Vehicle(string type)
        {
            this.type = type;
        }

        public string getType()
        {
            return this.type;
        }
    }
}
