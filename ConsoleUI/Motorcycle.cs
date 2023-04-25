using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    internal class Motorcycle : Vehicle
    {
        public Motorcycle()
        { 
        }

        public bool HasSideCart { get; set; }

        public override void DriveAbstract()
        {
            Console.WriteLine("This motorcycle is abstractly in drive");
        }
        public override void DriveVirtual()
        {
            Console.WriteLine("This motorcycle is virtually in drive");
        }
    }
}
