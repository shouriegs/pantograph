using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ZedGraph;
using System.IO.Ports;

namespace PrototypeWithVectors
{
    public partial class PrototypeCmdDlg : Form
    {
        FiveBarMechanism fiveBarMechanism;
        LetterClass letter;
        //VectorClass homePosition;
        GraphPane graphPane;
        Timer timer, timer2;
        int curveIndex;
        int pointIndex;
        int drawFlag;

        private SerialPort serialPort;


        //float l = 5;
        //double x;
        //double y, v, w, a, b, m, n;
        double rx1 = -120, rx2 = -5, ry1 = -200, ry2 = 100;//only if l=50
        string input;
        double x, y;

        List<CurveClass> traceCurveList;
        List<PointPair> mistakePoints;
        PointPairList currentCurvePointsForTrace;
        int traceIndex;
        List<LineItem> drawMistakePoints;
        
        //int drawn = 0;
        ////PointPairList use1 = new PointPairList();
        ////double counter = 0;
        ////List<PointPairList> ppl = new List<PointPairList>();
        //PointPairList topone = new PointPairList();
        double _theta1, _theta5;



        //PointPairList bottomright = new PointPairList();

        public PrototypeCmdDlg()
        {
            InitializeComponent();

            cmbSerialPorts.DataSource = SerialPort.GetPortNames();
            if (cmbSerialPorts.Items.Count == 0)
            {
                MessageBox.Show("Serial Port Not Connected!");
                this.Close();
            }

            cmbSerialPorts.SelectedIndex = 0;

            timer = new Timer();
            timer.Interval = 1; //ms
            timer.Tick += Timer_Tick;

            timer2 = new Timer();
            timer2.Interval = 1; //ms
            timer2.Tick += Timer_Tick2;


            graphPane = zedGraphControl1.GraphPane;
            graphPane.XAxis.Scale.Min = -250;
            graphPane.XAxis.Scale.Max = 250;
            graphPane.YAxis.Scale.Min = -250;
            graphPane.YAxis.Scale.Max = 250;

            traceCurveList = new List<CurveClass>();
            currentCurvePointsForTrace = new PointPairList();
            mistakePoints = new List<PointPair>();

            fiveBarMechanism = new FiveBarMechanism(100, 125, 125, 30, 100, 0, 30, 90);
            DrawFiveBar();

            LetterClass.previousX = fiveBarMechanism.VectorT.X;
            LetterClass.previousY = fiveBarMechanism.VectorT.Y;

            //x = rx1;
            //y = ry1;
            //timer2.Start();

            input = inputAlpha.Text;

        }

        private void Timer_Tick2(object sender, EventArgs e)
        {
            x = xTrack.Value;
            y = yTrack.Value;
            xTrackValue.Text = x.ToString();
            yTrackValue.Text = y.ToString();
            fiveBarMechanism = new FiveBarMechanism(50, 50, 50, 50, 50, 0, x, y, 'o');
            DrawFiveBar();
            LetterClass.previousX = fiveBarMechanism.VectorT.X;
            LetterClass.previousY = fiveBarMechanism.VectorT.Y;
        }

        private void DrawFiveBar()
        {
            if (fiveBarMechanism == null)
                return;

            graphPane.CurveList.Clear();

            PointPair _pointPairO = new PointPair(fiveBarMechanism.VectorO.X, fiveBarMechanism.VectorO.Y);
            PointPair _pointPairP = new PointPair(fiveBarMechanism.VectorP.X, fiveBarMechanism.VectorP.Y);
            PointPair _pointPairQ = new PointPair(fiveBarMechanism.VectorQ.X, fiveBarMechanism.VectorQ.Y);
            PointPair _pointPairR = new PointPair(fiveBarMechanism.VectorR.X, fiveBarMechanism.VectorR.Y);
            PointPair _pointPairS = new PointPair(fiveBarMechanism.VectorS.X, fiveBarMechanism.VectorS.Y);
            PointPair _pointPairT = new PointPair(fiveBarMechanism.VectorT.X, fiveBarMechanism.VectorT.Y);

            PointPairList pointPairListLink1 = new PointPairList();
            PointPairList pointPairListLink2 = new PointPairList();
            PointPairList pointPairListLink3 = new PointPairList();
            PointPairList pointPairListLink4 = new PointPairList();
            PointPairList pointPairListLink5 = new PointPairList();
            PointPairList pointPairListLink3Prime = new PointPairList();

            pointPairListLink1.Add(_pointPairO);
            pointPairListLink1.Add(_pointPairP);
            LineItem _one = graphPane.AddCurve("", pointPairListLink1, Color.Red, SymbolType.Circle);

            pointPairListLink2.Add(_pointPairP);
            pointPairListLink2.Add(_pointPairQ);
            LineItem _two = graphPane.AddCurve("", pointPairListLink2, Color.Black, SymbolType.Circle);

            pointPairListLink3.Add(_pointPairQ);
            pointPairListLink3.Add(_pointPairR);
            LineItem _three = graphPane.AddCurve("", pointPairListLink3, Color.Blue, SymbolType.Circle);

            pointPairListLink4.Add(_pointPairR);
            pointPairListLink4.Add(_pointPairS);
            LineItem _four = graphPane.AddCurve("", pointPairListLink4, Color.Green, SymbolType.Circle);

            pointPairListLink5.Add(_pointPairS);
            pointPairListLink5.Add(_pointPairO);
            LineItem _five = graphPane.AddCurve("", pointPairListLink5, Color.Orange, SymbolType.Circle);

            pointPairListLink3Prime.Add(_pointPairT);
            pointPairListLink3Prime.Add(_pointPairQ);
            LineItem _3Prime = graphPane.AddCurve("", pointPairListLink3Prime, Color.Violet, SymbolType.Circle);

            zedGraphControl1.Invalidate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            serialPort.Write("180" + "," + "0" + "?e");
        }

        private void cmdConnectSerialPort_Click(object sender, EventArgs e)
        {
            serialPort = new SerialPort();
            serialPort.PortName = cmbSerialPorts.Text;
            serialPort.BaudRate = 9600;
            serialPort.Open();
        }

        private void PrototypeCmdDlg_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (serialPort == null)
                return;

            if (serialPort.IsOpen)
                serialPort.Close();
        }

        private void cmdStartDrawingLetter_Click(object sender, EventArgs e)
        {
            

            letter = null;
            LetterClass.previousX = fiveBarMechanism.VectorT.X;
            LetterClass.previousY = fiveBarMechanism.VectorT.Y;

            input = inputAlpha.Text;
            VectorClass _origin = new VectorClass(rx1, ry1);
            switch (input)
            {
                case "A":
                    letter = new LetterClassA(_origin);
                    break;
                case "B":
                    letter = new LetterClassB(_origin);
                    break;
                case "C":
                    letter = new LetterClassC(_origin);
                    break;
                case "D":
                    letter = new LetterClassD(_origin);
                    break;
                case "E":
                    letter = new LetterClassE(_origin);
                    break;
                case "F":
                    letter = new LetterClassF(_origin);
                    break;
                case "G":
                    letter = new LetterClassG(_origin);
                    break;
                case "H":
                    letter = new LetterClassH(_origin);
                    break;
                case "I":
                    letter = new LetterClassI(_origin);
                    break;
                case "J":
                    letter = new LetterClassJ(_origin);
                    break;
                case "K":
                    letter = new LetterClassK(_origin);
                    break;
                case "L":
                    letter = new LetterClassL(_origin);
                    break;
                case "M":
                    letter = new LetterClassM(_origin);
                    break;
                case "N":
                    letter = new LetterClassN(_origin);
                    break;
                case "O":
                    letter = new LetterClassO(_origin);
                    break;
                case "P":
                    letter = new LetterClassP(_origin);
                    break;
                case "Q":
                    letter = new LetterClassQ(_origin);
                    break;
                case "R":
                    letter = new LetterClassR(_origin);
                    break;
                case "S":
                    letter = new LetterClassS(_origin);
                    break;
                case "T":
                    letter = new LetterClassT(_origin);
                    break;
                case "U":
                    letter = new LetterClassU(_origin);
                    break;
                case "V":
                    letter = new LetterClassV(_origin);
                    break;
                case "W":
                    letter = new LetterClassW(_origin);
                    break;
                case "X":
                    letter = new LetterClassX(_origin);
                    break;
                case "Y":
                    letter = new LetterClassY(_origin);
                    break;
                case "Z":
                    letter = new LetterClassZ(_origin);
                    break;
                case "0":
                    letter = new LetterClass0(_origin);
                    break;
                case "1":
                    letter = new LetterClass1(_origin);
                    break;
                case "2":
                    letter = new LetterClass2(_origin);
                    break;
                case "3":
                    letter = new LetterClass3(_origin);
                    break;
                case "4":
                    letter = new LetterClass4(_origin);
                    break;
                case "5":
                    letter = new LetterClass5(_origin);
                    break;
                case "6":
                    letter = new LetterClass6(_origin);
                    break;
                case "7":
                    letter = new LetterClass7(_origin);
                    break;
                case "8":
                    letter = new LetterClass8(_origin);
                    break;
                case "9":
                    letter = new LetterClass9(_origin);
                    break;
            }

            if (letter == null)
                return;
            
            curveIndex = 0;
            pointIndex = 0;

            traceCurveList = new List<CurveClass>();
            currentCurvePointsForTrace = new PointPairList();
            drawMistakePoints = new List<LineItem>();
            
            timer.Start();            
        }

        


        

        public void Timer_Tick(object sender, EventArgs e)
        {

            
            if (pointIndex == letter.CurvesList[curveIndex].PointsList.Count)
            {
                if (curveIndex == letter.CurvesList.Count-1)
                {
                    timer.Stop();
                    return;
                }

                if (letter.CurvesList[curveIndex].IsDrawingCurve)
                {
                    traceCurveList.Add(letter.CurvesList[curveIndex]);
                    currentCurvePointsForTrace = new PointPairList();
                }
                    
                curveIndex++;
                pointIndex = 0;
            }
            
                
            CurveClass _currentCurve = letter.CurvesList[curveIndex];
            
            VectorClass _currentPoint = _currentCurve.PointsList[pointIndex];
                                                  
            //counter = letter.CurvesList.Count; // ppl[0].Count;
            graphPane.CurveList.Clear();
            
            x = _currentPoint.X;
            y = _currentPoint.Y;
            fiveBarMechanism = new FiveBarMechanism(100, 125, 125, 30, 100, 0, x, y, 'o');
            DrawFiveBar();

            
            //draw Trace
            //earlier curves to be traced
            foreach(CurveClass _curveClass in traceCurveList)
            {
                LineItem _trace = graphPane.AddCurve("",GlobalClass.GetPointPairListFromVectorsList(_curveClass.PointsList), Color.DarkGray, SymbolType.None);
            }
            if(_currentCurve.IsDrawingCurve)
            {
                currentCurvePointsForTrace.Add(_currentPoint.X, _currentPoint.Y);
                LineItem _trace = graphPane.AddCurve("", currentCurvePointsForTrace, Color.DarkGray, SymbolType.None);
            }

            _theta1 = Math.Ceiling(fiveBarMechanism.Theta1);
            _theta5 = Math.Ceiling(fiveBarMechanism.Theta5);
            theta1Text.Text = _theta1.ToString();
            theta5Text.Text = _theta5.ToString();

            if (serialPort.IsOpen)
            {
                //int _angle1 = Convert.ToInt32(numAngle1.Value);
                //int _angle2 = Convert.ToInt32(numAngle2.Value);

                serialPort.Write(_theta1.ToString() + "," + _theta5.ToString() + "?e");

                //byte[] b = BitConverter.GetBytes(_angle1);
                //serialPort.Write(b, 0, 4);
            }

            while (true)
            {
                if (serialPort.ReadChar() == 'T')
                {
                    break;
                }
                else if(serialPort.ReadChar() =='F')
                {
                    mistakePoints.Add(GlobalClass.GetPointPairFromVector(_currentPoint));
                    break;
                }

            }

            int noOfMistakes = mistakePoints.Count;
            for(int i=0;i<noOfMistakes;i++)
            {
                graphPane.AddCurve("", GlobalClass.GetPointPairListFromVector(mistakePoints[i]), Color.Red, SymbolType.Star);
            }


            zedGraphControl1.Invalidate();

            pointIndex++;
            
            

        }

        

        private void PrototypeCmdDlg_Load(object sender, EventArgs e)
        {

        }

        private void inputAlpha_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
