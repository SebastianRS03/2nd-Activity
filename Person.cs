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
        public int KeyCode
        {
            get { return this.keyCode; }
            set
            {
                this.keyCode = value;
            }
        }
        private string firstName;
        public string FirstName
        {
            get { return this.firstName; }
            set
            {
                this.firstName = value;
            }
        }
        private string lastName;
        public string LastName
        {
            get { return this.lastName; }
            set
            {
                this.lastName = value;
            }
        }
        private int age;
        public int Age
        {
            get { return this.age; }
            set
            {
                this.age = value;
            }
        }
        private char gender;
        public char Gender
        {
            get { return this.gender; }
            set
            {
                this.gender = value;
            }
        }
        private List<License> licenses;
        public List<License> Licenses
        {
            get { return this.licenses; }
            set
            {
                this.licenses = value;
            }
        }
        private static int licenseCounter;
        public int LicenseCounter
        {
            get { return Person.licenseCounter; }
            set
            {
                Person.licenseCounter = value;
            }
        }
        private List<Vehicle> vehicles;
        public List<Vehicle> Vehicles
        {
            get { return this.vehicles; }
            set
            {
                this.vehicles = value;
            }
        }
        private static int vehicleCounter;
        public int VehicleCounter
        {
            get { return Person.vehicleCounter; }
            set
            {
                Person.vehicleCounter = value;
            }
        }
        private Boolean suspicionFraud;
        public Boolean SuspicionFraud
        {
            get { return this.suspicionFraud; }
            set
            {
                this.suspicionFraud = value;
            }
        }

        public Person(string firstName, string lastName, int age, char gender)
        {
            Person.licenseCounter = 0;
            Person.vehicleCounter = 0;
            this.keyCode = generateKeyCode(firstName, lastName, age, gender);
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.gender = gender;
            this.licenses = new List<License>();
            this.vehicles = new List<Vehicle>();
            this.suspicionFraud = false;
        }

        public int generateKeyCode(string firstName, string lastName, int age, char gender)
        {
            return firstName[0] + lastName[0] + firstName[1] + lastName[1] + age + gender;
        }

        public void addVehicle(Vehicle vehicle)
        {
            if (Person.vehicleCounter > 4)
            {
                Console.WriteLine("You own more than 5 cars, you're a suspect of fraud.");
                this.suspicionFraud = true;
            }
            else if(this.suspicionFraud == true){
                Console.WriteLine("You're suspect of fraud. We'll call the police!");
            }
            else
            {
                switch (vehicle.Color)
                {
                    case "Red": 
                        if (this.gender == 'F')
                        {
                            vehicle.Valid = true;
                            Console.WriteLine("The vehicle was added.");
                            this.vehicles.Add(vehicle);
                            Person.vehicleCounter++;
                        }
                        else
                        {
                            switch (vehicle.Brand)
                            {
                                case "Toyota":
                                    vehicle.Valid = true;
                                    Console.WriteLine("The vehicle was added.");
                                    this.vehicles.Add(vehicle);
                                    Person.vehicleCounter++;
                                    break;
                                case "Ford":
                                    vehicle.Valid = true;
                                    Console.WriteLine("The vehicle was added.");
                                    this.vehicles.Add(vehicle);
                                    Person.vehicleCounter++;
                                    break;
                                default:
                                    Console.WriteLine("Mr. " + this.lastName + ", your car is neither Ford nor Toyota, you wouldn't like it. Try with a different brand.");
                                    break;
                            }
                        }
                        break;
                    default:
                        if (this.gender == 'F')
                        {
                            Console.WriteLine("Ms. " + this.lastName + ", your car isn't red you wouldn't like. Try with a different color.");
                        }
                        else
                        {
                            switch (vehicle.Brand)
                            {
                                case "Toyota":
                                    vehicle.Valid = true;
                                    Console.WriteLine("The vehicle was added.");
                                    this.vehicles.Add(vehicle);
                                    Person.vehicleCounter++;
                                    break;
                                case "Ford":
                                    vehicle.Valid = true;
                                    Console.WriteLine("The vehicle was added.");
                                    this.vehicles.Add(vehicle);
                                    Person.vehicleCounter++;
                                    break;
                                default:
                                    Console.WriteLine("Mr. " + this.lastName + ", your car is neither Ford nor Toyota, you wouldn't like it. Try with a different brand.");
                                    break;
                            }
                        }
                        break;
                }
                //if (this.gender == 'F' && vehicle.Color != "Red")
                //{
                //    Console.WriteLine("Ms. " + this.lastName + ", your car is red you wouldn't like. Try with a different color.");
                //}
                //else if(!vehicle.Brand.Equals("Ford") || !vehicle.Brand.Equals("Toyota"))
                //{
                //    Console.WriteLine("Mr. " + this.lastName + ", your car is neither Ford nor Toyota, you wouldn't like it. Try with a different brand.");
                //}
                //else
                //{
                //    vehicle.Valid = true;
                //    Console.WriteLine("The vehicle was added.");
                //    this.vehicles.Add(vehicle);
                //    Person.vehicleCounter++;
                //}
            }
        }

        public void addLicense(License license, Vehicle vehicle)
        {
            for (int i = 0; i < this.LicenseCounter; i++)
            {
                if (this.Licenses[i].Type == vehicle.Type)
                {
                    Console.WriteLine("You already have a license of that type.");
                    license.Status = false;
                }
                else
                {
                    Console.WriteLine("All your data is in order. Your license will be granted.");
                }
            }
            if (license.Status == true)
            {
                this.licenses.Add(license);
                Person.licenseCounter++;
            }
        }

        public void cancelVehicle(Vehicle vehicle, License license)
        {
            for (int i = 0; i < vehicleCounter; i++)
            {
                if (vehicle == this.vehicles[i])
                {
                    if (license.Status == true)
                    {
                        Console.WriteLine("Your vehicle was canceled.");
                        this.vehicles.Remove(vehicle);
                        this.VehicleCounter--;
                    }
                    else
                    {
                        Console.WriteLine("Your license is expired. You can't cancel your vehicle.");
                    }
                }
                else
                {
                    Console.WriteLine("The vehicle wasn't found. Try again.");
                }
            }
        }

        public void showPerson()
        {
            Console.WriteLine("\n=============== Person ===============");
            Console.WriteLine("Key code: " + this.keyCode);
            Console.WriteLine("Person: " + this.firstName + " " + this.lastName);
            Console.WriteLine("Age: " + this.age);
            Console.WriteLine("Gender: " + this.gender);
            Console.WriteLine("Is a suspect of fraud? " + this.suspicionFraud);
            Console.WriteLine("\n=============== Licenses ===============");
 
            foreach (License license in licenses)
            {
                license.showLicense();
            }
            Console.WriteLine("\n=============== Vehicles ===============");
            foreach (Vehicle vehicle in vehicles)
            {
                vehicle.showVehicle();
            }

        }
    }
}
