using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class Motorcycle : Vehicles
    {
        public bool HasSideCar { get; set; }
        public bool HasSideCart { get; internal set; }

        public override void DriveAbstract()
        {
            Console.WriteLine("The motorcycle is being driven");
        }

        public override void DriveVirtual()
        {
            Console.WriteLine("The motorcycle is being riden");
        }
    }
}
