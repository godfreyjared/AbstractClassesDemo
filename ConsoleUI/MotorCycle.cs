using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class MotorCycle : Vehicle
    {
        public bool HasSideCart { get; set; }
        public override void DriveAbstract()
        {
            Console.WriteLine("The motorcycle is functioning and ready to ride!");
        }

        public override void DriveVirtual()
    {
        Console.WriteLine("Motor Cycle's Virtual Drive Method.");
    } 
    }
}