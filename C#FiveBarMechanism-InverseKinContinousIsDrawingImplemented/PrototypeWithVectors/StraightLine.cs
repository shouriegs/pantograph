using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypeWithVectors
{
    public class StraightLine : CurveClass
    {

        VectorClass startPoint, endPoint;

        public VectorClass StartPoint
        {
            set { startPoint = value; }
            get { return startPoint; }
        }

        public VectorClass EndPoint
        {
            set { endPoint = value; }
            get { return endPoint; }
        }

        //constructor
        public StraightLine(VectorClass _startPoint, VectorClass _endPoint, bool _isDrawing)
        {
            startPoint = _startPoint;
            endPoint = _endPoint;
            stepSize = 0.25;
            isDrawingCurve = _isDrawing;
            PopulatePointsData();
        }


        public override void PopulatePointsData()
        {
            base.PopulatePointsData();

            VectorClass _deltaVector = VectorClass.Subtract(endPoint, startPoint);
            for (double t = 0; t <= 1; t += stepSize)
            {
                VectorClass _intermediatePoint = VectorClass.Add(startPoint, VectorClass.ScalarMultiply(_deltaVector, t));
                pointsList.Add(_intermediatePoint);
            }
        }

        //public List<VectorClass> GeneratePointList()
        //{            
        //    List<VectorClass> _listPoints = new List<VectorClass>();
        //    VectorClass _deltaVector = VectorClass.Subtract(endPoint, startPoint);
        //    for (double t = 0; t <= 1; t += 0.01)
        //    {
        //        VectorClass _intermediatePoint = VectorClass.Add(startPoint,  VectorClass.ScalarMultiply(_deltaVector, t));
        //        _listPoints.Add(_intermediatePoint);
        //    }
        //    return _listPoints;

        //}

    }
}
