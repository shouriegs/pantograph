using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypeWithVectors
{
    class LetterClass0 : LetterClass
    {
        //any variables specific to this letter

        public LetterClass0(VectorClass _origin)
        {
            origin = _origin;
            PopulateCurvesList();
        }

        public override void PopulateCurvesList()
        {
            base.PopulateCurvesList();

            double _fontSize = GlobalClass.FontSize;
            VectorClass _point1 = VectorClass.ScalarMultiply(new VectorClass(0.5, 0.5), _fontSize);

            VectorClass _point0 = new VectorClass(LetterClass.previousX, LetterClass.previousY);
            _point1 = VectorClass.Add(_point1, origin);

            CircularArc _arc1 = new CircularArc(_point1, 0.5 * _fontSize, 90, 450, true, true);

            StraightLine _line0 = new StraightLine(_point0, _point1, false);
            curvesList.Add(_line0);


            curvesList.Add(_arc1);

        }
    }
}
