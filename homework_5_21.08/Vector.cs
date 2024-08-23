using System;

namespace Geometry
{
    public class Vector
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Vector() { X = 0; Y = 0; }
        public Vector(double x, double y) { X = x; Y = y; }
    }
}
