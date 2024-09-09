namespace homework_12_06._09
{
    public class Roof : IPart
    {
        public decimal Completeness {  get; set; }
        public decimal Difficulty { get; init; }

        public Roof()
        {
            Difficulty = 1;
            Completeness = 0;
        }

        public override string ToString()
        {
            if (Completeness == 0) return "Roof not built".PadRight(20) + "-";
            else if (Completeness == 100) return "Roof is built".PadRight(20) + "OK";
            else return $"Building roof".PadRight(20) + $"{Completeness:F2}%";
        }
    }
}
