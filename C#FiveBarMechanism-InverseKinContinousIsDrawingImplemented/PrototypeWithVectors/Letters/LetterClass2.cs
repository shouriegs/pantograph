using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypeWithVectors
{
    class LetterClass2 : LetterClass
    {
        //any variables specific to this letter

        public LetterClass2(VectorClass _origin)
        {
            origin = _origin;
            PopulateCurvesList();
        }

        public override void PopulateCurvesList()
        {
            base.PopulateCurvesList();

            double _fontSize = GlobalClass.FontSize;
            VectorClass _point1 = VectorClass.ScalarMultiply(new VectorClass(0.4, 0.6), _fontSize);
            VectorClass _point2 = VectorClass.ScalarMultiply(new VectorClass(0.8, 0.6), _fontSize);
            VectorClass _point3 = VectorClass.ScalarMultiply(new VectorClass(0, 0), _fontSize);
            VectorClass _point4 = VectorClass.ScalarMultiply(new VectorClass(0.8, 0), _fontSize);

            VectorClass _point0 = new VectorClass(LetterClass.previousX, LetterClass.previousY);
            _point1 = VectorClass.Add(_point1, origin);
            _point2 = VectorClass.Add(_point2, origin);
            _point3 = VectorClass.Add(_point3, origin);
            _point4 = VectorClass.Add(_point4, origin);

            VectorClass _pointStart = new VectorClass(_point1.X + (0.4 * _fontSize) * Math.Cos(Math.PI), _point1.Y + (0.5 * _fontSize) * Math.Sin(Math.PI));

            CircularArc _arc1 = new CircularArc(_point1, 0.4 * _fontSize, 180, 0, false, true);
            StraightLine _line1 = new StraightLine(_point2, _point3, true);
            StraightLine _line2 = new StraightLine(_point3, _point4, true);

            StraightLine _line0 = new StraightLine(_point0, _pointStart, false);
            curvesList.Add(_line0);

            curvesList.Add(_arc1);
            curvesList.Add(_line1);
            curvesList.Add(_line2);

        }
    }
}

