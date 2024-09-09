namespace homework_12_06._09
{
    internal class Basement : IPart
    {
        public decimal Completeness { get; set; }
        public decimal Difficulty { get; init; }

        public Basement()
        {
            Difficulty = 0.3M;
            Completeness = 0;
        }

        public override string ToString()
        {
            if (Completeness == 0) return "Basement not built".PadRight(20) + "-";
            else if (Completeness == 100) return "Basement is built".PadRight(20) + "OK";
            else return "Building basement".PadRight(20) + $"{Completeness:F2}%";
        }
    }
}
