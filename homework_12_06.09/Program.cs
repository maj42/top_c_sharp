namespace homework_12_06._09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            House house = new House();
            Team team = new Team();
            TeamLeader leader = new TeamLeader();

            while (true)
            {
                if (rand.Next(5) == 0)
                {
                    leader.Inspect(house);
                }
                else 
                {
                    if (team.Work(house)) Console.WriteLine("Working");
                    else
                    {
                        Console.WriteLine("      ':.\r\n         []_____\r\n        /\\      \\\r\n    ___/  \\__/\\__\\__\r\n---/\\___\\ |''''''|__\\-- ---\r\n   ||'''| |''||''|''|\r\n   ``\"\"\"`\"`\"\"))\"\"`\"\"`");
                        Console.ReadLine();
                        return;
                    }
                }
                Console.WriteLine();
                System.Threading.Thread.Sleep(300);
            }
        }
    }
}
