namespace homework_12_06._09
{
    public class Worker : IWorker
    {
        public int Productivity { get; init; }

        public Worker(int productivity)
        {
            Productivity = productivity;
        }
    }
}
