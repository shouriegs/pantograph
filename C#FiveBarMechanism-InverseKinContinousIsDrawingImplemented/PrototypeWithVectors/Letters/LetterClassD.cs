using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypeWithVectors
{
    class LetterClassD : LetterClass
    {
        //any variables specific to this letter

        public LetterClassD(VectorClass _origin)
        {
            origin = _origin;
            PopulateCurvesList();
        }

        public override void PopulateCurvesList()
        {
            base.PopulateCurvesList();

            double _fontSize = GlobalClass.FontSize;
            VectorClass _point1 = VectorClass.ScalarMultiply(new VectorClass(0, 1), _fontSize);
            VectorClass _point2 = VectorClass.ScalarMultiply(new VectorClass(0, 0), _fontSize);
            VectorClass _point3 = VectorClass.ScalarMultiply(new VectorClass(0.25, 1), _fontSize);
            VectorClass _point4 = VectorClass.ScalarMultiply(new VectorClass(0.25, 0.5), _fontSize);
            VectorClass _point5 = VectorClass.ScalarMultiply(new VectorClass(0.25, 0), _fontSize);

            VectorClass _point0 = new VectorClass(LetterClass.previousX, LetterClass.previousY);
            _point1 = VectorClass.Add(_point1, origin);
            _point2 = VectorClass.Add(_point2, origin);
            _point3 = VectorClass.Add(_point3, origin);
            _point4 = VectorClass.Add(_point4, origin);
            _point5 = VectorClass.Add(_point5, origin);

            StraightLine _line1 = new StraightLine(_point1, _point2, true);
            StraightLine _line2 = new StraightLine(_point2, _point1, false);
            StraightLine _line3 = new StraightLine(_point1, _point3, true);
            CircularArc _arc1 = new CircularArc(_point4, 0.5 * _fontSize, 90, -90, false, true);
            StraightLine _line4 = new StraightLine(_point5, _point2, true);

            StraightLine _line0 = new StraightLine(_point0, _point1, false);
            curvesList.Add(_line0);


            curvesList.Add(_line1);
            curvesList.Add(_line2);
            curvesList.Add(_line3);
            curvesList.Add(_arc1);
            curvesList.Add(_line4);


        }
    }
}
