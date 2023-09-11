using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypeWithVectors
{
    class LetterClassV : LetterClass
    {
        //any variables specific to this letter

        public LetterClassV(VectorClass _origin)
        {
            origin = _origin;
            PopulateCurvesList();
        }

        public override void PopulateCurvesList()
        {
            base.PopulateCurvesList();

            double _fontSize = GlobalClass.FontSize;
            VectorClass _point1 = VectorClass.ScalarMultiply(new VectorClass(0, 1), _fontSize);
            VectorClass _point2 = VectorClass.ScalarMultiply(new VectorClass(0.3, 0), _fontSize);
            VectorClass _point3 = VectorClass.ScalarMultiply(new VectorClass(0.6, 1), _fontSize);
            

            _point1 = VectorClass.Add(_point1, origin);
            _point2 = VectorClass.Add(_point2, origin);
            _point3 = VectorClass.Add(_point3, origin);
            

            StraightLine _line1 = new StraightLine(_point1, _point2, true);
            StraightLine _line2 = new StraightLine(_point2, _point3, true);

            VectorClass _point0 = new VectorClass(LetterClass.previousX, LetterClass.previousY);
            StraightLine _line0 = new StraightLine(_point0, _point1, false);
            curvesList.Add(_line0);

            curvesList.Add(_line1);
            curvesList.Add(_line2);

        }
    }
}