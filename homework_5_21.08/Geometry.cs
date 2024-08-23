using System;

namespace Geometry
{
    public class Geometry
    {
        public static double GetLength(Vector vec)
        {
            return Math.Sqrt(vec.X * vec.X + vec.Y * vec.Y);
        }

        public static double GetLength(Segment seg)
        {
            return Math.Sqrt(Math.Pow(seg.begin.X - seg.end.X, 2) + Math.Pow(seg.begin.Y - seg.end.Y, 2));
        }

        public static Vector Add(Vector vec1, Vector vec2)
        {
            return new Vector(vec1.X + vec2.X, vec1.Y + vec2.Y);
        }

        public static bool IsVectorInSegment(Vector vec, Segment seg)
        {
            double length1 = GetLength(new Segment(vec.X, vec.Y, seg.begin.X, seg.begin.Y));
            double length2 = GetLength(new Segment(vec.X, vec.Y, seg.end.X, seg.end.Y));
            double length3 = GetLength(seg);
            double halfPerim = (length1 + length2 + length3) / 2;
            bool colinearity = !Convert.ToBoolean((halfPerim - length1) * (halfPerim - length2) * (halfPerim - length3));
            bool bounding = ((vec.X >= seg.begin.X ^ vec.X >= seg.end.X) && (vec.Y >= seg.begin.Y ^ vec.Y >= seg.end.Y));
            return bounding && colinearity;
        }
    }
}
