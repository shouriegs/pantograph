using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace PrototypeWithVectors
{
    public abstract class CurveClass
    {
        protected List<VectorClass> pointsList;
        protected bool isDrawingCurve;
        protected Color color;
        protected double stepSize;

        public List<VectorClass> PointsList
        {
            set { pointsList = value; }
            get { return pointsList; }
        }

        public bool IsDrawingCurve
        {
            set { isDrawingCurve = value; }
            get { return isDrawingCurve; }
        }

        public Color Color
        {
            set { color = value; }
            get { return color; }
        }

        public double StepSize
        {
            set { stepSize = value; }
            get { return stepSize; }
        }

        public CurveClass()
        {

        }

        public virtual void PopulatePointsData()
        {
            //will be implemented in children
            pointsList = new List<VectorClass>();
        }

        

    }
}
