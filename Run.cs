using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* ADT Activity: 
   The transport general direction needs its software developers to build a vehicle management
   system, these vehicles must be associated with people who have the ability to drive them and to
   have the licenses that allow their use. To facilitate the handling of this information, it is 
   required the creation of abstract data types, so they have asked for your help. */
namespace _2nd_Activity
{
    internal class Run
    {
        private static void Main(string[] args)
        {
            /* Condition 1: A person cannot be granted a license if he or she is over 90 years old. */

            //Register register1 = new Register();
            //Person person1 = new Person("Francisco", "Sarabia", 91, 'M');
            //Vehicle vehicle1 = new Vehicle("A", 2022, "Toyota", "Gibi", 4, "Black");
            //Vehicle vehicle2 = new Vehicle("B", 2015, "Toyota", "Abraham", 2, "White");
            //person1.addVehicle(vehicle1);
            //person1.addVehicle(vehicle2);
            //License license1 = new License(person1, vehicle1);
            //License license2 = new License(person1, vehicle2);
            //person1.addLicense(license1, vehicle1);
            //person1.addLicense(license2, vehicle2);
            //register1.addPeople(person1);
            //register1.printData();

            /* Condition 2: Women like only red vehicles, so they will reject any other. */

            //Register register1 = new Register();
            //Person person1 = new Person("Pamela", "Ochoa", 32, 'F');
            //Vehicle vehicle1 = new Vehicle("A", 2003, "Ford", "Edumovil", 4, "Gold");
            //Vehicle vehicle2 = new Vehicle("B", 2019, "Italika", "Didi", 2, "Red");
            //person1.addVehicle(vehicle1);
            //person1.addVehicle(vehicle2);
            //License license1 = new License(person1, vehicle1);
            //License license2 = new License(person1, vehicle2);
            //person1.addLicense(license1, vehicle1);
            //person1.addLicense(license2, vehicle2);
            //register1.addPeople(person1);
            //register1.printData();

            /* Condition 3: Another license of the same type cannot be granted unless the previous
            one is expired. */

            //Register register1 = new Register();
            //Person person1 = new Person("Pedro", "Paez", 45, 'M');
            //Vehicle vehicle1 = new Vehicle("A", 2003, "Ford", "Edumovil", 4, "Gold");
            //Vehicle vehicle2 = new Vehicle("B", 2019, "Ford", "Didi", 2, "Red");
            //Vehicle vehicle3 = new Vehicle("A", 2022, "Toyota", "Gibi", 4, "Black");
            //person1.addVehicle(vehicle1);
            //person1.addVehicle(vehicle2);
            //person1.addVehicle(vehicle3);
            //License license1 = new License(person1, vehicle1);
            //License license2 = new License(person1, vehicle2);
            //License license3 = new License(person1, vehicle3);
            //person1.addLicense(license1, vehicle1);
            //person1.addLicense(license2, vehicle2);
            //person1.addLicense(license3, vehicle3);
            //register1.addPeople(person1);
            //register1.printData();

            /* Condition 4: Men only accept vehicles of the brands: Ford and Toyota. */

            //Register register1 = new Register();
            //Person person1 = new Person("Pedro", "Paez", 45, 'M');
            //Vehicle vehicle1 = new Vehicle("A", 2003, "Ford", "Edumovil", 4, "Gold");
            //Vehicle vehicle2 = new Vehicle("B", 2019, "Nissan", "Didi", 2, "Red");
            //Vehicle vehicle3 = new Vehicle("A", 2022, "Toyota", "Gibi", 4, "Black");
            //Vehicle vehicle4 = new Vehicle("B", 2015, "Toyota", "Abraham", 2, "White");
            //Vehicle vehicle5 = new Vehicle("A", 2008, "Chevrolet", "Brayan", 4, "Blue");
            //person1.addVehicle(vehicle1);
            //person1.addVehicle(vehicle2);
            //person1.addVehicle(vehicle3);
            //person1.addVehicle(vehicle4);
            //person1.addVehicle(vehicle5);
            //License license1 = new License(person1, vehicle1);
            //License license2 = new License(person1, vehicle4);
            //person1.addLicense(license1, vehicle1);
            //person1.addLicense(license2, vehicle4);
            //register1.addPeople(person1);
            //register1.printData();

            /* Condition 5: People who have more than 5 vehicles are considered suspected of fraud. */

            //Register register1 = new Register();
            //Person person1 = new Person("Pedro", "Paez", 45, 'M');
            //Vehicle vehicle1 = new Vehicle("A", 2003, "Ford", "Edumovil", 4, "Gold");
            //Vehicle vehicle2 = new Vehicle("B", 2019, "Ford", "Didi", 2, "Red");
            //Vehicle vehicle3 = new Vehicle("A", 2022, "Toyota", "Gibi", 4, "Black");
            //Vehicle vehicle4 = new Vehicle("B", 2015, "Toyota", "Abraham", 2, "White");
            //Vehicle vehicle5 = new Vehicle("A", 2008, "Ford", "Brayan", 4, "Blue");
            //Vehicle vehicle6 = new Vehicle("B", 2000, "Toyota", "Fercho", 4, "Blue");
            //person1.addVehicle(vehicle1);
            //person1.addVehicle(vehicle2);
            //person1.addVehicle(vehicle3);
            //person1.addVehicle(vehicle4);
            //person1.addVehicle(vehicle5);
            //person1.addVehicle(vehicle6);
            //License license1 = new License(person1, vehicle1);
            //License license2 = new License(person1, vehicle2);
            //person1.addLicense(license1, vehicle1);
            //person1.addLicense(license2, vehicle2);
            //register1.addPeople(person1);
            //register1.printData();

            /* Condition 6: You cannot cancel a vehicle if you do not have a valid license for it. */

            //Register register1 = new Register();
            //Person person1 = new Person("Pedro", "Paez", 45, 'M');
            //Vehicle vehicle1 = new Vehicle("A", 2003, "Ford", "Edumovil", 4, "Gold");
            //Vehicle vehicle2 = new Vehicle("B", 2019, "Ford", "Didi", 2, "Red");
            //Vehicle vehicle3 = new Vehicle("A", 2022, "Toyota", "Gibi", 4, "Black");
            //person1.addVehicle(vehicle1);
            //person1.addVehicle(vehicle2);
            //License license1 = new License(person1, vehicle1);
            //License license2 = new License(person1, vehicle2);
            //person1.addLicense(license1, vehicle1);
            //person1.addLicense(license2, vehicle2);
            //person1.cancelVehicle(vehicle2, license1);
            //person1.cancelVehicle(vehicle3, license1);
            //register1.addPeople(person1);
            //register1.printData();
        }
    }
}
