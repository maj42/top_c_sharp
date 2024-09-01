using System;

namespace homework_9_30._08
{
    public class Vector
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Vector() { X = 0; Y = 0; }
        public Vector(double x, double y) { X = x; Y = y; }

        static public Vector operator +(Vector first, Vector second)
        {
            return new Vector(first.X + second.X, first.Y + second.Y);
        }

        static public Vector operator -(Vector first, Vector second)
        {
            return new Vector(first.X - second.X, first.Y - second.Y);
        }

        static public Vector operator /(Vector vec, double scalar)
        {
            return new Vector(vec.X / scalar, vec.Y / scalar);
        }

        static public Vector operator +(Vector vec)
        {
            return vec;
        }

        static public Vector operator -(Vector vec)
        {
            return new Vector(-vec.X, -vec.Y);
        }

        static public Vector operator ++(Vector vec)
        {
            vec.X++;
            vec.Y++;
            return vec;
        }

        static public Vector operator --(Vector vec)
        {
            vec.X--;
            vec.Y--;
            return vec;
        }

        public override string ToString()
        {
            return $"Vector {X}, {Y}";
        }
    }
}
