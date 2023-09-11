using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypeWithVectors
{
    public class VectorClass
    {

        //variables
        private double x;
        private double y;

        //properties
        public double X
        {
            set { x = value; }
            get { return x; }
        }

        public double Y
        {
            set { y = value; }
            get { return y; }
        }

        //constructor
        public VectorClass()
        {
            x = 0;
            y = 0;

        }

        //constructor overloading
        public VectorClass(double _x, double _y)
        {
            x = _x;
            y = _y;

        }

        public static VectorClass Add(VectorClass v1, VectorClass v2)
        {
            return new VectorClass(v1.X + v2.X, v1.Y + v2.Y);
        }

        public static VectorClass Subtract(VectorClass v1, VectorClass v2)
        {
            return new VectorClass(v1.X - v2.X, v1.Y - v2.Y);
        }

        public static VectorClass ScalarMultiply(VectorClass v1, double t)
        {
            return new VectorClass(v1.X * t, v1.Y * t);
        }


        //public static double distance(VectorClass v1, VectorClass v2)
        //{
        //    double dis = 0;
        //    dis = Math.Sqrt((v1.X * v1.X) + (v2.Y * v2.Y));

        //    return dis;
        //}

    }
}
