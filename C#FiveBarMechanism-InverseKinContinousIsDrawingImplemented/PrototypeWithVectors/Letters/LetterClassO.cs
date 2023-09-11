using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypeWithVectors
{
    class LetterClassO : LetterClass
    {
        //any variables specific to this letter

        public LetterClassO(VectorClass _origin)
        {
            origin = _origin;
            PopulateCurvesList();
        }

        public override void PopulateCurvesList()
        {
            base.PopulateCurvesList();

            double _fontSize = GlobalClass.FontSize;
            VectorClass _point1 = VectorClass.ScalarMultiply(new VectorClass(0.5, 0.5), _fontSize);

            
            _point1 = VectorClass.Add(_point1, origin);

            VectorClass _pointStart = new VectorClass(_point1.X + (0.5 * _fontSize) * Math.Cos(Math.PI / 2), _point1.Y + (0.5 * _fontSize) * Math.Sin(Math.PI / 2));

            CircularArc _arc1 = new CircularArc(_point1, 0.5 * _fontSize, 90, 450, true, true);

            VectorClass _point0 = new VectorClass(LetterClass.previousX, LetterClass.previousY);
            StraightLine _line0 = new StraightLine(_point0, _pointStart, false);
            curvesList.Add(_line0);

            curvesList.Add(_arc1);
            
        }
    }
}
