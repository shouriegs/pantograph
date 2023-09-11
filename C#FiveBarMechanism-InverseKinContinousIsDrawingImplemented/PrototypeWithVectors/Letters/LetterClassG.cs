using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypeWithVectors
{
    class LetterClassG : LetterClass
    {
        //any variables specific to this letter

        public LetterClassG(VectorClass _origin)
        {
            origin = _origin;
            PopulateCurvesList();
        }

        public override void PopulateCurvesList()
        {
            base.PopulateCurvesList();

            double _fontSize = GlobalClass.FontSize;
            VectorClass _point1 = VectorClass.ScalarMultiply(new VectorClass(0.5, 0.5), _fontSize);
            VectorClass _point2 = VectorClass.ScalarMultiply(new VectorClass(0.5, 0), _fontSize);
            VectorClass _point3 = VectorClass.ScalarMultiply(new VectorClass(0.5, 0.3), _fontSize);
            VectorClass _point4 = VectorClass.ScalarMultiply(new VectorClass(0.75, 0.3), _fontSize);
            VectorClass _point5 = VectorClass.ScalarMultiply(new VectorClass(0.75, 0), _fontSize);

            VectorClass _point0 = new VectorClass(LetterClass.previousX, LetterClass.previousY);
            _point1 = VectorClass.Add(_point1, origin);
            _point2 = VectorClass.Add(_point2, origin);
            _point3 = VectorClass.Add(_point3, origin);
            _point4 = VectorClass.Add(_point4, origin);
            _point5 = VectorClass.Add(_point5, origin);

            VectorClass _pointStart = new VectorClass(_point1.X + (0.5 * _fontSize) * Math.Cos(Math.PI / 4), _point1.Y + (0.5 * _fontSize) * Math.Sin(Math.PI / 4));

            CircularArc _arc1 = new CircularArc(_point1, 0.5 * _fontSize, 45, 270, true, true);
            StraightLine _line1 = new StraightLine(_point2, _point3, true);
            StraightLine _line2 = new StraightLine(_point3, _point4, true);
            StraightLine _line3 = new StraightLine(_point4, _point5, true);

            StraightLine _line0 = new StraightLine(_point0, _pointStart, false);
            curvesList.Add(_line0);

            curvesList.Add(_arc1);
            curvesList.Add(_line1);
            curvesList.Add(_line2);
            curvesList.Add(_line3);


        }
    }
}
