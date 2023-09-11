using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypeWithVectors
{
    class LetterClass3 : LetterClass
    {
        //any variables specific to this letter

        public LetterClass3(VectorClass _origin)
        {
            origin = _origin;
            PopulateCurvesList();
        }

        public override void PopulateCurvesList()
        {
            base.PopulateCurvesList();

            double _fontSize = GlobalClass.FontSize;
            VectorClass _point1 = VectorClass.ScalarMultiply(new VectorClass(0.25, 0.75), _fontSize);
            VectorClass _point2 = VectorClass.ScalarMultiply(new VectorClass(0.25, 0.25), _fontSize);

            VectorClass _point0 = new VectorClass(LetterClass.previousX, LetterClass.previousY);
            _point1 = VectorClass.Add(_point1, origin);
            _point2 = VectorClass.Add(_point2, origin);

            VectorClass _pointStart = new VectorClass(_point1.X + (0.25 * _fontSize) * Math.Cos(Math.PI), _point1.Y + (0.25 * _fontSize) * Math.Sin(Math.PI));

            CircularArc _arc1 = new CircularArc(_point1, 0.25 * _fontSize, 180, -90, false, true);
            CircularArc _arc2 = new CircularArc(_point2, 0.25 * _fontSize, 90, -180, false, true);

            StraightLine _line0 = new StraightLine(_point0, _pointStart, false);
            curvesList.Add(_line0);

            curvesList.Add(_arc1);
            curvesList.Add(_arc2);

        }
    }
}

