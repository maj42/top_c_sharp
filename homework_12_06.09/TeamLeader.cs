namespace homework_12_06._09
{
    public class TeamLeader
    {
        public void Inspect(House house)
        {
            Console.WriteLine("Teamlead is here");
            foreach (IPart part in house) Console.WriteLine(part);
        }
    }
}
