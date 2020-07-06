using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ConsoleUI
{
    public class Car : Vehicle
    {
        public Car()
        {

        }
        public bool HasTrunk { get; set; } = true;
            public override void DriveAbstract()
        {
            Console.WriteLine("This car is in drive");
        }
    }
    
}
