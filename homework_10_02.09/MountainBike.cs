using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_10_02._09
{
    internal class MountainBike
    {
        internal int Speed { get; private set; }
        internal int Gear { get; private set; }

        internal MountainBike() { Speed = 0; }

        internal void Start() 
        {
            Console.WriteLine("Starting bike");
            Speed = 5 * Gear;
        }

        internal void Stop()
        {
            Console.WriteLine("Stopping bike");
            Speed = 0;
        }

        internal void ChangeGear(int gear)
        {
            if (gear < 1) gear = 1;
            else if (gear > 6) gear = 6;
            Console.WriteLine("Changing gear to " + gear);
            if (Speed != 0) Speed = 5 * gear;
        }
    }
}
