using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_10_02._09
{
    internal interface IBicycle
    {
        void Start();
        void Stop();
        int Speed { get; }
        void ChangeGear(int gear);
    }

    internal interface IElectricBicycle : IBicycle
    {
        void ChargeBattery(int amount);
        int BatteryLevel { get; }
    }
}
