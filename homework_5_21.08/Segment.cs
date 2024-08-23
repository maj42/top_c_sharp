using System;

namespace Geometry
{
    public class Segment
    {
        public Vector begin { get; set; }
        public Vector end { get; set; }

        public Segment()
        {
            this.begin = new Vector();
            this.end = new Vector();
        }
        public Segment(double X1, double Y1, double X2, double Y2)
        {
            this.begin = new Vector(X1, Y1);
            this.end = new Vector(X2, Y2);
        }
        public Segment(Vector begin, Vector end)
        {
            this.begin = begin;
            this.end = end;
        }
    }
}
