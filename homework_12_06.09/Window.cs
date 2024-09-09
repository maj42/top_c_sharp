namespace homework_12_06._09
{
    internal class Window : IPart
    {
        public decimal Completeness { get; set; }
        public decimal Difficulty { get; init; }

        public Window()
        {
            Difficulty = 0.8M;
            Completeness = 0;
        }

        public override string ToString()
        {
            if (Completeness == 0) return "Window not built".PadRight(20) + "-";
            else if (Completeness == 100) return "Window is built".PadRight(20) + "OK";
            else return "Building window".PadRight(20) + $"{Completeness:F2}%";
        }
    }
}
