using System;
using System.Collections.Generic;
using System.Linq;
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
             * DONE - Create an abstract class called Vehicle
             * DONE - The vehicle class shall have three string properties Year, Make, and Model
             * DONE - Set the defaults to something generic in the Vehicle class
             * DONE - Vehicle shall have an abstract method called DriveAbstract with no implementation
             * DONE - Vehicle shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* 
             * Done - Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * Done - Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * Done - Provide the implementations for the abstract methods
             * Done - Only in the Motorcycle class will you override the virtual drive method
            */

            // Create a list of Vehicle called vehicles
            var vehicles = new List<Vehicle>();
            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * - new it up as one of each derived class
             * Set the properties with object initializer syntax
             */
            var Focus = new Car() { HasTrunk = true, Make = "Ford", Model = "Focus", Year = 2013 };
            var motorcycle = new Motorcycle() { HasSideCart = true, Make = "HD", Model = "Chopper", Year = 1970 };

            Vehicle sedan = new Car() { HasTrunk = true, Make = "Dodge", Model = "Ram", Year = 2013 };
            Vehicle sport = new Car() { HasTrunk = false, Make = "ferari", Model = "Something fast", Year = 2020 };


            // 
            //* Add the 4 vehicles to the list
            //* Using a foreach loop iterate over each of the properties
            //
            vehicles.Add(Focus);
            vehicles.Add(motorcycle);
            vehicles.Add(sedan);
            vehicles.Add(sport);

            foreach (var veh in vehicles)
            {
                Console.WriteLine($"Make {veh.Make} Model{veh.Model} Year{veh.Year}");
                veh.DriveAbstract();
            }


            // Call each of the drive methods for one car and one motorcycle

            #endregion
            Console.ReadLine();
        }
    }
}
