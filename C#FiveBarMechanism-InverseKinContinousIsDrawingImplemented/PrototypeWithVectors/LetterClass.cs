using System;
using System.Collections.Generic;
using System.Text;


namespace PrototypeWithVectors
{
    public abstract class LetterClass
    {

        protected List<CurveClass> curvesList;
        protected VectorClass origin;
        protected double theta;
        public static double previousX, previousY;

        public List<CurveClass> CurvesList
        {
            set { curvesList = value; }
            get { return curvesList; }
        }

        public VectorClass Origin
        {
            set { origin = value; }
            get { return origin; }
        }

        public double Theta
        {
            set { theta = value; }
            get { return theta; }
        }

        public  LetterClass()
        {

        }

        public double PreviousX
        {
            set { previousX = value; }
            get { return (previousX); }
        }

        public double PreviousY
        {
            set { previousY = value; }
            get { return (previousY); }
        }

        public virtual void PopulateCurvesList()
        {
            curvesList = new List<CurveClass>();
        }


        //List<PointPairList> PPL=new List<PointPairList>();

        //public List<PointPairList> produceListOfLines(string input)
        //{
        //    switch (input)
        //    {
        //        case "A":
        //            VectorClass startPoint = new VectorClass(-55, 60);
        //            VectorClass endPoint = new VectorClass(-55, 100);
        //            StraightLine Line1 = new StraightLine(startPoint, endPoint);
        //            List<VectorClass> linePoints = Line1.GeneratePointList();
        //            PointPairList one = new PointPairList();
        //            foreach (VectorClass point in linePoints)
        //            {
        //                one.Add(new PointPair(point.X, point.Y));
        //            }
        //            PPL.Add(one);

        //            break;


        //    }
        //    return PPL;
        //}
    }
}
