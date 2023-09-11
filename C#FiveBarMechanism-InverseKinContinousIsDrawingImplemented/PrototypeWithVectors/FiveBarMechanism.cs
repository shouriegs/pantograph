using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypeWithVectors
{
    public class FiveBarMechanism
    {
        //variables
        double a1, a2, a3, a3Prime, a4, a5;
        double theta1, theta5;
        VectorClass vectorO, vectorP, vectorQ, vectorR, vectorS, vectorT;

        //properties
        public double Theta1
        {
            set { theta1 = value; }
            get { return theta1; }
        }

        public double Theta5
        {
            set { theta5 = value; }
            get { return theta5; }
        }

        public VectorClass VectorO
        {
            set { vectorO = value; }
            get { return vectorO; }
        }

        public VectorClass VectorP
        {
            set { vectorP = value; }
            get { return vectorP; }
        }

        public VectorClass VectorQ
        {
            set { vectorQ = value; }
            get { return vectorQ; }
        }

        public VectorClass VectorR
        {
            set { vectorR = value; }
            get { return vectorR; }
        }

        public VectorClass VectorS
        {
            set { vectorS = value; }
            get { return vectorS; }
        }

        public VectorClass VectorT
        {
            set { vectorT = value; }
            get { return vectorT; }
        }

        //constructor
        public FiveBarMechanism()
        {
            a1 = 50; a2 = 50; a3 = 50; a3Prime = 50; a4 = 50; a5 = 50;
            theta1 = GlobalClass.DegreeToRadian(120);
            theta5 = GlobalClass.DegreeToRadian(60);
            vectorO = new VectorClass(0, 0);
            vectorS = new VectorClass(a5, 0);
            ForwardKinematics();
        }

        public FiveBarMechanism(double _a1, double _a2, double _a3, double _a3Prime, double _a4, double _a5, double _theta1, double _theta5)
        {
            a1 = _a1; a2 = _a2; a3 = _a3; a3Prime = _a3Prime; a4 = _a4; a5 = _a5;
            theta1 = GlobalClass.DegreeToRadian(_theta1);
            theta5 = GlobalClass.DegreeToRadian(_theta5);
            vectorO = new VectorClass(0, 0);
            vectorS = new VectorClass(a5, 0);
            ForwardKinematics();
        }

        public FiveBarMechanism(double _a1, double _a2, double _a3, double _a3Prime, double _a4, double _a5, double _vectorTx, double _vectorTy, char c)
        {
            a1 = _a1; a2 = _a2; a3 = _a3; a3Prime = _a3Prime; a4 = _a4; a5 = _a5;
            
            vectorO = new VectorClass(0, 0);
            vectorS = new VectorClass(-a5, 0);
            InverseKinematics(_vectorTx, _vectorTy);
        }

        public void ForwardKinematics()
        {
            vectorR = new VectorClass(a5 + a4 * Math.Cos(theta5), a4 * Math.Sin(theta5));

            vectorP = new VectorClass(a1 * Math.Cos(theta1), a1 * Math.Sin(theta1));

            double _px, _py, _rx, _ry, _tx, _ty;
            double _qx, _qy1, _qy, _qy2;
            double a6 = a3 + a3Prime;
            _px = vectorP.X;
            _py = vectorP.Y;
            _rx = vectorR.X;
            _ry = vectorR.Y;

            double _k, _l, _m, _e, _f, _g, _h;
            _k = (a2 * a2) - (a3 * a3) + (_ry * _ry) - (_py * _py) - (_px * _px) + (_rx * _rx);
            _l = 2 * (_rx - _px);
            _m = 2 * (_ry - _py);
            _e = (_m * _m) + (_l * _l);
            _f = (2 * _l * _px * _m) - (2 * _k * _m) - (2 * _py * _l * _l);
            _g = (_l * _l * _px * _px) + (_k * _k) + (_l * _l * _py * _py) - (a2 * a2 * _l * _l) - (2 * _l * _px * _k);
            _h = Math.Sqrt((_f * _f) - (4 * _e * _g));
            _qy1 = (-_f + _h) / (2 * _e);
            _qy2 = (-_f - _h) / (2 * _e);

            if (_qy1 > _qy2)
                _qy = _qy1;
            else
                _qy = _qy2;

            _qx = (_k - (_m * _qy)) / _l;

            vectorQ = new VectorClass(_qx, _qy);

            _tx = ((a6 * _qx) - (a3Prime * _rx)) / a3;
            _ty = ((a6 * _qy) - (a3Prime * _ry)) / a3;

            vectorT = new VectorClass(_tx, _ty);

            vectorO = VectorClass.ScalarMultiply(vectorO, -1);
            vectorP = VectorClass.ScalarMultiply(vectorP, -1);
            vectorQ = VectorClass.ScalarMultiply(vectorQ, -1);
            vectorR = VectorClass.ScalarMultiply(vectorR, -1);
            vectorS = VectorClass.ScalarMultiply(vectorS, -1);
            vectorT = VectorClass.ScalarMultiply(vectorT, -1);
        }

        public void InverseKinematics(double _x,double _y)
        {
            //take input as vectorT.X and vectorT.Y
            //calculate values of theta1 and theta5 and set their values
            //double _x, _y;
            vectorT = new VectorClass(_x, _y);

            double _c, _d, _a, _e, _f, _g, _h, _b, _p, _m, _v, _w, _i, _n, _j, _k, _l;
            double a6 = a3 + a3Prime;

            _c = (a6 * a6) - (a4 * a4) + (a5 * a5) - (_x * _x) - (_y * _y);
            _d = -2 * (a5 + _x);
            _e = (4 * _y * _y) + (_d * _d);
            _f = (4 * _y * a5 * _d) + (4 * _c * _y);
            _g = (_c * _c) + (_d * _d * a5 * a5) - (a4 * a4 * _d * _d) + (2 * a5 * _c * _d);
            _h = Math.Sqrt((_f * _f) - (4 * _e * _g));
            _b = (-_f + _h) / (2 * _e);
            _a = (_c + (2 * _b * _y)) / _d;

            
            vectorR = new VectorClass(_a, _b);

            _v = ((a3Prime * _a) + (a3 * _x)) / a6;
            _w = ((a3Prime * _b) + (a3 * _y)) / a6;

            vectorQ = new VectorClass(_v, _w);

            _i = (_v * _v) + (_w * _w) + (a1 * a1) - (a2 * a2);
            _j = 4 * ((_w * _w) + (_v * _v));
            _k = 4 * _i * _v;
            _l = (_i * _i) - (4 * _w * _w * a1 * a1);
            _p = Math.Sqrt((_k * _k) - (4 * _l * _j));
            _m = (_k + _p) / (2 * _j);
            _n = (_i - (2 * _v * _m)) / (2 * _w);

            vectorP = new VectorClass(_m, _n);

            theta1 = (Math.Atan2(_n, _m) * 180) / Math.PI;
            theta5 = (Math.Atan2(_b, _a) * 180) / Math.PI;

            theta1 = theta1 + 180;
            theta5 = theta5 + 180;

        }
    }
}

