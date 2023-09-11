using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypeWithVectors
{
    class LetterClassQ : LetterClass
    {
        //any variables specific to this letter

        public LetterClassQ(VectorClass _origin)
        {
            origin = _origin;
            PopulateCurvesList();
        }

        public override void PopulateCurvesList()
        {
            base.PopulateCurvesList();

            double _fontSize = GlobalClass.FontSize;
            VectorClass _point1 = VectorClass.ScalarMultiply(new VectorClass(0.5, 0.5), _fontSize);
            VectorClass _point2 = VectorClass.ScalarMultiply(new VectorClass(0.5, 1), _fontSize);
            VectorClass _point3 = VectorClass.ScalarMultiply(new VectorClass(1, 0), _fontSize);

            _point1 = VectorClass.Add(_point1, origin);
            _point2 = VectorClass.Add(_point2, origin);
            _point3 = VectorClass.Add(_point3, origin);

            VectorClass _pointStart = new VectorClass(_point1.X + (0.5 * _fontSize) * Math.Cos(Math.PI / 2), _point1.Y + (0.5 * _fontSize) * Math.Sin(Math.PI / 2));

            CircularArc _arc1 = new CircularArc(_point1, 0.5 * _fontSize, 90, 450, true, true);
            StraightLine _line1 = new StraightLine(_point2, _point1, false);
            StraightLine _line2 = new StraightLine(_point1, _point3, false);

            VectorClass _point0 = new VectorClass(LetterClass.previousX, LetterClass.previousY);
            StraightLine _line0 = new StraightLine(_point0, _pointStart, false);
            curvesList.Add(_line0);

            curvesList.Add(_arc1);
            curvesList.Add(_line1);
            curvesList.Add(_line2);

        }
    }
}
