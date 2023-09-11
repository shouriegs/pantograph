using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypeWithVectors
{
    class LetterClassS : LetterClass
    {
        //any variables specific to this letter

        public LetterClassS(VectorClass _origin)
        {
            origin = _origin;
            PopulateCurvesList();
        }

        public override void PopulateCurvesList()
        {
            base.PopulateCurvesList();

            double _fontSize = GlobalClass.FontSize;
            VectorClass _point1 = VectorClass.ScalarMultiply(new VectorClass(0.5, 0.75), _fontSize);
            VectorClass _point2 = VectorClass.ScalarMultiply(new VectorClass(0.5, 0.25), _fontSize);

            _point1 = VectorClass.Add(_point1, origin);
            _point2 = VectorClass.Add(_point2, origin);

            VectorClass _pointStart = new VectorClass(_point1.X + (0.25 * _fontSize) * Math.Cos(0), _point1.Y + (0.25 * _fontSize) * Math.Sin(0));

            CircularArc _arc1 = new CircularArc(_point1, 0.25 * _fontSize, 0, 270, true, true);
            CircularArc _arc2 = new CircularArc(_point2, 0.25 * _fontSize, 90, -180, false, true);

            VectorClass _point0 = new VectorClass(LetterClass.previousX, LetterClass.previousY);
            StraightLine _line0 = new StraightLine(_point0, _pointStart, false);
            curvesList.Add(_line0);


            curvesList.Add(_arc1);
            curvesList.Add(_arc2);

        }
    }
}
