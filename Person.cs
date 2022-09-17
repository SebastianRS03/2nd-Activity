using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2nd_Activity
{
    internal class Person
    {
        private int keyCode;
        private string firstName;
        private string lastName;
        private int age;
        private char gender;
        private List<License> licenses;
        private static int licenseCounter;
        private List<Vehicle> vehicles;
        private static int vehicleCounter;
        private Boolean suspicionFraud;

        public Person(int keyCode, string firstName, string lastName, int age, char gender, List<License> licenses, List<Vehicle> vehicles, Boolean suspicionFraud)
        {
            this.keyCode = keyCode;
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.gender = gender;
            this.licenses = licenses;
            this.vehicles = vehicles;
            this.suspicionFraud = suspicionFraud;
        }

        public Person(int keyCode)
        {
            this.keyCode = keyCode;
        }

        public int getKeyCode()
        {
            return this.keyCode;
        }

        public int getAge()
        {
            return this.age;
        }

        public string getFirstName()
        {
            return this.firstName;
        }

        public string getLastName()
        {
            return this.lastName;
        }

        public List<License> getLicenses()
        {
            return this.licenses;
        }

        public int getLicenseCounter()
        {
            return Person.licenseCounter;
        }

        public void addVehicle(Vehicle vehicle, Boolean suspicionFraud)
        {
            if (Person.vehicleCounter > 5)
            {
                this.suspicionFraud = true;
            }
            else if(suspicionFraud == true){
                Console.WriteLine("You're suspect of fraud. We'll call the police!");
            }
            else
            {
                Console.WriteLine("The vehicle was added.");
                this.vehicles.Add(vehicle);
                vehicleCounter++;
            }
        }

        public void cancelVehicle(Vehicle vehicle, License license, string firstName, string lastaName)
        {
            for (int i = 0; i < vehicleCounter; i++)
            {
                if (vehicle == this.vehicles[i])
                {
                    if (person.getFirstName() == firstName && person.getLastName() == lastName)
                    {
                        if (license.getStatus() == true)
                        {
                            this.vehicles.Remove(vehicle);
                        }
                    }
                    else
                    {
                        Console.WriteLine("You don't have a car with those specifications.");
                    }
                }
                else
                {
                    Console.WriteLine("The vehicle wasn't found. Try again.");
                }
            }
        }
    }
}
