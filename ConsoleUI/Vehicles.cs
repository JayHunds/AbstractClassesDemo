using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public abstract class Vehicles
    {
        public string Year { get; set; } = "2006";
        public string Make { get; set; } = "Toyota";
        public string Model { get; set; } = "Tacoma";

        public abstract void DriveAbstract();
        public virtual void DriveVirtual()
        {
            Console.WriteLine("This Vehicle is being driven.");
        }
    }
}
