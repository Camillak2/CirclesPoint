using System;

namespace CirclesPoint
{
    public class Circle
    {
        public double R { get; set; }

        public Circle(double r)
        {
            R = r;
        }

        public byte CheckOnEntry(double x, double y)
        {
            byte result = PointInInnerCircleOrRectangle(x, y);

            if (result != 0)
            {
                return result;
            }
            return PointInInnerCircleOrRectangle(x, y);
        }

        public byte PointInInnerCircleOrRectangle(double x, double y)
        {
            if (Math.Pow(x, 2) + Math.Pow(y, 2) <= Math.Pow(R, 2))
            {
                if (x <= 0 && y >= 0)
                {
                    return 1;
                }
            }

            else if ((x >= 0 && x <= 2 * R) && (y <= 0 && y >= -R))
            {
                return 1;
            }

            return 0;
        }

        public byte PointInOuterCircle(double x, double y)
        {
            if (Math.Pow(x, 2) + Math.Pow(y, 2) <= Math.Pow(R, 2) && Math.Pow(x, 2) + Math.Pow(y, 2) >= Math.Pow(R, 2) && (y <= 0 && x >= 0))
            {
                return 2;
            }

            return 0;
        }
    }
}
