using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_10_02._09
{
    internal class ElectricBike
    {
        internal int BatteryLevel { get; private set; }
        internal int Speed { get; private set; }
        internal int Gear { get; private set; }

        internal ElectricBike() { 
            Speed = 0;
            BatteryLevel = 70;
            Gear = 1;
        }

        internal void ChargeBattery(int amount)
        {
            if (amount + BatteryLevel > 100) amount = 100 - BatteryLevel;
            Console.WriteLine($"Charging for {amount}%");
            BatteryLevel += amount;
        }

        internal void Start()
        {
            Console.WriteLine("Starting electric bike");
            Speed = 10 * Gear;
        }

        internal void Stop()
        {
            Console.WriteLine("Stopping electric bike");
            Speed = 0;
        }

        internal void ChangeGear(int gear)
        {
            if (gear < 1) gear = 1;
            else if (gear > 6) gear = 6;
            Console.WriteLine("Changing electric bike gear to " + gear);
            if (Speed != 0) Speed = 10 * gear;
        }
    }
}
