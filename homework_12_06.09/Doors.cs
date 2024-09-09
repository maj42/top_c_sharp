namespace homework_12_06._09
{
    internal class Doors : IPart
    {
        public decimal Completeness { get; set; }
        public decimal Difficulty { get; init; }

        public Doors()
        {
            Difficulty = 0.6M;
            Completeness = 0;
        }

        public override string ToString()
        {
            if (Completeness == 0) return "Doors not built".PadRight(20) + "-";
            else if (Completeness == 100) return "Doors are built".PadRight(20) + "OK";
            else return "Building doors".PadRight(20) + $"{ Completeness:F2}%";
        }
    }
}
