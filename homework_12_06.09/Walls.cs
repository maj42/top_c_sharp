namespace homework_12_06._09
{
    internal class Walls : IPart
    {
        public decimal Completeness { get; set; }
        public decimal Difficulty { get; init; }

        public Walls()
        {
            Difficulty = 0.4M;
            Completeness = 0;
        }

        public override string ToString()
        {
            if (Completeness == 0) return "Walls not built".PadRight(20) + "-";
            else if (Completeness == 100) return "Walls are built".PadRight(20) + "OK";
            else return "Building walls".PadRight(20) + $"{Completeness:F2}%";
        }
    }
}
