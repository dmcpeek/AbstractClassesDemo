using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo follow all comments!! 
             */

            #region Vehicles

            /*
             * Create an abstract class called Vehicle
             * The vehicle class shall have three string properties Year, Make, and Model
             * Set the defaults to something generic in the Vehicle class
             * Vehicle shall have an abstract method called DriveAbstract with no implementation
             * Vehicle shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * Provide the implementations for the abstract methods
             * Only in the Motorcycle class will you override the virtual drive method
            */

            // Create a list of Vehicle called vehicles
            var vehicles = new List<Vehicle>();

            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * - set them up as one of each derived class
             * Set the properties with object initializer syntax
             */
            Car rav4 = new Car() { HasTrunk = true, Make = "Toyota", Model = "Rav4", Year = "2017" };
            Motorcycle ducati = new Motorcycle() { HasSideCart = false, Make = "Ducati", Model = "Panigale V4", Year = "2023" };

            Vehicle momCar = new Car() { HasTrunk = false, Make = "Honda", Model = "Family Van Sport", Year = "1984" };
            Vehicle stationWagon = new Car() { HasTrunk = true, Make = "Dodge", Model = "Aspen", Year = "1987" };
            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */
            vehicles.Add(rav4);
            vehicles.Add(ducati);
            vehicles.Add(stationWagon);
            vehicles.Add(momCar);

            foreach (var vehicle in vehicles)
            {
                Console.WriteLine($" Make: {vehicle.Make} \nModel: {vehicle.Model} \n Year: {vehicle.Year}");
                vehicle.DriveAbstract();
                vehicle.DriveVirtual();
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine();

            }

            Console.WriteLine("******************************");
            // Call each of the drive methods for one car and one motorcycle
            rav4.DriveAbstract();
            rav4.DriveVirtual();
            Console.WriteLine("\n");

            ducati.DriveAbstract();
            ducati.DriveVirtual();

            #endregion


        }
    }
}
