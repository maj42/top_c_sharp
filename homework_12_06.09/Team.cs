namespace homework_12_06._09
{
    public class Team
    {
        public Array workers = new Worker[] { };

        public Team() 
        {
            workers = new Worker[3] { new Worker(8), new Worker(9), new Worker(10)};
        }

        public bool Work(House house)
        {
            for (int current = 0; current < house.parts.Length; current++)
            {
                if (house[current].Completeness == 100) continue;
                foreach (Worker worker in workers)
                {
                    house[current].Completeness += worker.Productivity * house[current].Difficulty;
                    if (house[current].Completeness >= 100)
                    {
                        house[current].Completeness = 100;
                        break;
                    }
                }
                return true;
            }
            return false;
        }
    }
}
