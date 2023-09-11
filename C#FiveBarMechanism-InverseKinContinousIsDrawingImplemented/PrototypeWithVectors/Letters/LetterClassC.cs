using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypeWithVectors
{
    class LetterClassC : LetterClass
    {
        //any variables specific to this letter

        public LetterClassC(VectorClass _origin)
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
            
            CircularArc _arc1 = new CircularArc(_point1, 0.5 * _fontSize, 45, 315, true, true);

            VectorClass _pointStart = new VectorClass(_point1.X + (0.5 * _fontSize) * Math.Cos(Math.PI/4), _point1.Y + (0.5 * _fontSize) * Math.Sin(Math.PI / 4));

            StraightLine _line0 = new StraightLine(_point0, _pointStart, false);
            curvesList.Add(_line0);

            curvesList.Add(_arc1);
            

        }
    }
}
