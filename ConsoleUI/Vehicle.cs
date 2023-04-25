using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public abstract class Vehicle
    {
        public string Year { get; set; } = "Default value";
        public string Make { get; set; } = "Default value";
        public string Model { get; set; } = "Default value";

        public abstract void DriveAbstract(); //Stubbed out method, means no implementation nor logic

        public virtual void DriveVirtual()
        {
            Console.WriteLine($"Default vehicle is virtually in drive.");
        }
    }
}
