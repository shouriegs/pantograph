using System;
using System.Collections.Generic;
using System.Text;
using ZedGraph;

namespace PrototypeWithVectors
{
    class GlobalClass
    {
        public static double FontSize = 35;
        

        public static double RadianToDegree(double _radian)
        {
            return _radian * 180.0 / Math.PI;
        }

        public static double DegreeToRadian(double _degree)
        {
            return _degree*Math.PI/180.0;
        }

        public static PointPairList GetPointPairListFromVectorsList(List<VectorClass> _vectorsList)
        {
            PointPairList _pointPairList = new PointPairList();
            foreach (VectorClass _vectorClass in _vectorsList)
                _pointPairList.Add(_vectorClass.X, _vectorClass.Y);

            return _pointPairList;
        }

        public static PointPairList GetPointPairListFromVector(PointPair _vector)
        {
            PointPairList _pointPairList = new PointPairList();
            _pointPairList.Add(_vector.X, _vector.Y);

            return _pointPairList;
        }

        public static PointPair GetPointPairFromVector(VectorClass _vector)
        {
            PointPair _pointPair = new PointPair();
            _pointPair.X = _vector.X;
            _pointPair.Y = _vector.Y;

            return _pointPair;
        }



    }
}
