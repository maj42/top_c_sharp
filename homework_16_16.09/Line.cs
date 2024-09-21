namespace homework_16_16._09
{
    public class Line<T>
    {
        public Dot<T> First { get; set; }
        public Dot<T> Second { get; set; }

        public Line(Dot<T> first, Dot<T> second) 
        {
            First = first;
            Second = second;
        }

        public Line(T firstX, T firstY, T secondX, T secondY)
        {
            First = new Dot<T>(firstX, firstY);
            Second = new Dot<T>(secondX, secondY);
        }

        public override string ToString()
        {
            return $"Line from {First.X}, {First.Y} to {Second.X}, {Second.Y}";
        }
    }

    public class Dot<T>
    {
        public T X { get; set; }
        public T Y { get; set; }

        public Dot(T x, T y)
        {
            X = x;
            Y = y;
        }
    }
}
