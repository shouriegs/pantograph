using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypeWithVectors
{
    public class CircularArc : CurveClass
    {
        private VectorClass center;
        private double radius;
        private double startAngle;
        private double endAngle;
        private bool ccw;

        public VectorClass Center
        {
            set { center = value; }
            get { return center; }
        }

        public double Radius
        {
            set { radius = value; }
            get { return radius; }
        }

        public double StartAngle
        {
            set { startAngle = value; }
            get { return startAngle; }
        }

        public double EndAngle
        {
            set { endAngle = value; }
            get { return endAngle; }
        }

        public bool CCW
        {
            set { ccw = value; }
            get { return ccw; }
        }


        public CircularArc(VectorClass _center, double _radius, double _startAngle, double _endAngle, bool _ccw, bool _isDrawingCurve)
        {
            center = _center;
            radius = _radius;
            startAngle = _startAngle;
            endAngle = _endAngle;
            ccw = _ccw;
            isDrawingCurve = _isDrawingCurve;
            stepSize = 10; //degree
            PopulatePointsData();
        }

        public override void PopulatePointsData()
        {
            base.PopulatePointsData();

            if (ccw)
                PopulatePointsDataForCCW();
            else
                PopulatePointsDataForCW();            
        }

        private void PopulatePointsDataForCCW()
        {
            //tbd
            //double _deltaTheta = endAngle - startAngle;
            for (double _theta = startAngle; _theta <= endAngle; _theta = _theta + stepSize)
            {
                double _thetaRadians = GlobalClass.DegreeToRadian(_theta);
                double _x = center.X + radius * Math.Cos(_thetaRadians);
                double _y = center.Y + radius * Math.Sin(_thetaRadians);
                VectorClass _intermediatePoint = new VectorClass(_x, _y);
                pointsList.Add(_intermediatePoint);
            }
        }

        private void PopulatePointsDataForCW()
        {
            //double _deltaTheta = endAngle - startAngle;
            for (double _theta = startAngle; _theta >= endAngle; _theta = _theta - stepSize)
            {
                double _thetaRadians = GlobalClass.DegreeToRadian(_theta);
                double _x = center.X + radius * Math.Cos(_thetaRadians);
                double _y = center.Y + radius * Math.Sin(_thetaRadians);
                VectorClass _intermediatePoint = new VectorClass(_x, _y);
                pointsList.Add(_intermediatePoint);
            }
        }
    }
}
