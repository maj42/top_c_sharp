using System;

namespace Geometry
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vector vec1 = new Vector(1, 1);
            Vector vec2 = new Vector(3, 3);

            Console.WriteLine($"Length of vector 1: {Geometry.GetLength(vec1):f4}");
            Console.WriteLine($"Length of vector 2: {Geometry.GetLength(vec2):f4}");

            Console.WriteLine($"Length of a resulting vector: {Geometry.GetLength(Geometry.Add(vec1, vec2)):f4}");

            Segment seg = new Segment(vec1, vec2);
            Vector vec3 = new Vector(1823, 333);
            Vector vec4 = new Vector();
            Vector vec5 = new Vector(2, 2);

            Console.WriteLine($"Length of a segment: {Geometry.GetLength(seg):f4}");
            Console.WriteLine($"Point {vec3.X}, {vec3.Y} is on a segment? {Geometry.IsVectorInSegment(vec3, seg)} (should be false)");
            Console.WriteLine($"Point {vec4.X}, {vec4.Y} is on a segment? {Geometry.IsVectorInSegment(vec4, seg)} (should be false)");
            Console.WriteLine($"Point {vec5.X}, {vec5.Y} is on a segment? {Geometry.IsVectorInSegment(vec5, seg)} (should be true)");
        }
    }
}
