namespace homework_10_02._09
{
    class Program
    {
        static void Main(string[] args)
        {
            MountainBike bike = new();
            ElectricBike ebike = new();

            ebike.ChargeBattery(123234);
            ebike.Start();
            ebike.ChangeGear(3);
            Console.WriteLine($"Electric bike speed: {ebike.Speed}\nCharge level: {ebike.BatteryLevel}");
            ebike.Stop();
        }
    }
}
