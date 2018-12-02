using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AimpathSimulation
{
    public partial class MainForm : Form
    {
        public Random rnd;

        public MainForm()
        {
            InitializeComponent();
            liveSimbut.Checked = true;
            linearbut.Checked = true;
            setbut.Checked = true;
            rnd = new Random();
        }

        private void smoothbar_Scroll(object sender, EventArgs e)
        {
            smoothlabel.Text = smoothbar.Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            Graphics g = drawPanel.CreateGraphics();
            PointF[] points = PreparePanel(g);
            if (overaimbutton.Checked || overaimnoisebut.Checked)
                runOveraimSim(g, points);
            else if (curvebut.Checked)
                runCurveSim(g, points);
            else
                runLinearSim(g, points);

            button1.Enabled = true;
        }

        public void runCurveSim(Graphics g, PointF[] points)
        {
            PointF currDrawPoint = points[0];
            PointF Destination = points[1];
            Point controlPoint = new Point(rnd.Next(10, 550), rnd.Next(10, 550));
            Brush lineBrush = new SolidBrush(Color.White);
            Brush pointBrush = new SolidBrush(Color.Red);

            for (double i = 0;i<=1;i+=1 / (double)smoothbar.Value)
            {
                Point drawLocation = BezierPoint( Point.Round(currDrawPoint), controlPoint, Point.Round(Destination),  i);
                g.DrawLine(new Pen(lineBrush, 1), currDrawPoint, drawLocation);
                currDrawPoint = drawLocation;
                Thread.Sleep(25);
            }
            g.DrawLine(new Pen(lineBrush, 1), currDrawPoint, Destination);
            g.FillRectangle(pointBrush, new Rectangle(Point.Round(points[0]), new Size(2, 2)));
            g.FillRectangle(pointBrush, new Rectangle(Point.Round(points[1]), new Size(2, 2)));
            g.FillRectangle(pointBrush, new Rectangle(controlPoint, new Size(2, 2)));

        }

        public void runOveraimSim(Graphics g, PointF[] points)
        {
            PointF currDrawPoint = points[0];
            PointF originalDestination = points[1];

            float overaimFactor = overaimbar.Value / 100f;
            float xAdder = (originalDestination.X - currDrawPoint.X) * overaimFactor;
            float yAdder = (originalDestination.Y - currDrawPoint.Y) * overaimFactor;
            PointF overaimDestination = new PointF(originalDestination.X + xAdder, originalDestination.Y + yAdder);

            Point drawOveraim = new Point((int)overaimDestination.X, (int)overaimDestination.Y);
            Brush pointBrush = new SolidBrush(Color.Red);
            Brush lineBrush = new SolidBrush(Color.White);
            Brush overaimBrush = new SolidBrush(Color.Blue);
            g.FillRectangle(pointBrush, new Rectangle(drawOveraim, new Size(1, 1)));

            while ((int)Math.Round(currDrawPoint.X) != (int)Math.Round(overaimDestination.X) || (int)Math.Round(currDrawPoint.Y) != (int)Math.Round(overaimDestination.Y))
            {
                Vector3 p1 = new Vector3();
                p1.X = currDrawPoint.X;
                p1.Y = currDrawPoint.Y;
                Vector3 p2 = new Vector3();
                p2.X = overaimDestination.X;
                p2.Y = overaimDestination.Y;

                Vector3 smoothedVector = Smooth(p1, p2, smoothbar.Value);

                PointF newDrawPoint = new PointF(smoothedVector.X, smoothedVector.Y);
                
                g.DrawLine(new Pen(lineBrush, 1), currDrawPoint, newDrawPoint);
                currDrawPoint = newDrawPoint;
                Thread.Sleep(15);
            }

            while ((int)Math.Round(currDrawPoint.X) != (int)Math.Round(originalDestination.X) || (int)Math.Round(currDrawPoint.Y) != (int)Math.Round(originalDestination.Y))
            {
                Vector3 p1 = new Vector3();
                p1.X = currDrawPoint.X;
                p1.Y = currDrawPoint.Y;
                Vector3 p2 = new Vector3();
                p2.X = originalDestination.X;
                p2.Y = originalDestination.Y;

                Vector3 smoothedVector = Smooth(p1, p2, smoothbar.Value);

                PointF newDrawPoint = new PointF(smoothedVector.X, smoothedVector.Y);

                g.DrawLine(new Pen(overaimBrush, 1), currDrawPoint, newDrawPoint);
                currDrawPoint = newDrawPoint;
                Thread.Sleep(15);
            }

            g.FillRectangle(pointBrush, new Rectangle(Point.Round(points[0]), new Size(2, 2)));
            g.FillRectangle(pointBrush, new Rectangle(Point.Round(points[1]), new Size(2, 2)));
            g.FillRectangle(pointBrush, new Rectangle(drawOveraim, new Size(2, 2)));
        }

        public void runLinearSim(Graphics g, PointF[] points)
        {
            PointF currDrawPoint = points[0];
            PointF destination = points[1];
            Brush pointBrush = new SolidBrush(Color.Red);
            Brush brush = new SolidBrush(Color.White);

            while((int)Math.Round(currDrawPoint.X) != destination.X || (int)Math.Round(currDrawPoint.Y) != destination.Y)
            {
                Vector3 p1 = new Vector3();
                p1.X = currDrawPoint.X;
                p1.Y = currDrawPoint.Y;
                Vector3 p2 = new Vector3();
                p2.X = destination.X;
                p2.Y = destination.Y;

                if(curvebut.Checked)
                {
                    Vector3 Delta = p2 - p1;
                    Delta += new Vector3(Delta.Y / 50, Delta.X / 50, Delta.Z);

                    destination.X = currDrawPoint.X + Delta.X;
                    destination.Y = currDrawPoint.Y + Delta.Y;
                }

                Vector3 smoothedVector = Smooth(p1, p2, smoothbar.Value);

                PointF newDrawPoint = new PointF(smoothedVector.X, smoothedVector.Y);

                g.DrawLine(new Pen(brush, 1), currDrawPoint, newDrawPoint);
                currDrawPoint = newDrawPoint;
                Thread.Sleep(15);
            }
            g.FillRectangle(pointBrush, new Rectangle(Point.Round(points[0]), new Size(2, 2)));
            g.FillRectangle(pointBrush, new Rectangle(Point.Round(points[1]), new Size(2, 2)));
        }

        public PointF[] PreparePanel(Graphics g)
        {
            Point startPoint = new Point(50, 250);
            Point endPoint = new Point(520, 250);
            if (randombut.Checked)
            {
                /*if(overaimnoisebut.Checked || overaimbutton.Checked)
                {
                    startPoint = new Point(rnd.Next(10, 572), rnd.Next(10, 572));
                    endPoint = new Point(rnd.Next(10, (int)(572 * (1f - overaimbar.Value / 100f))), rnd.Next(10, (int)(572 * (1f - overaimbar.Value / 100f))));
                }
                else
                {
                    startPoint = new Point(rnd.Next(10, 572), rnd.Next(10, 498));
                    endPoint = new Point(rnd.Next(10, 572), rnd.Next(10, 498));
                }*/
                startPoint = new Point(rnd.Next(10, 550), rnd.Next(10, 550));
                endPoint = new Point(rnd.Next(10, 572), rnd.Next(10, 550));
            }
            
            g.FillRectangle(new SolidBrush(Color.Black), drawPanel.DisplayRectangle);
            Brush pointBrush = new SolidBrush(Color.Red);
            g.FillRectangle(pointBrush, new Rectangle(startPoint, new Size(2, 2)));
            g.FillRectangle(pointBrush, new Rectangle(endPoint, new Size(2, 2)));
            Thread.Sleep(1000);
            return new PointF[] { startPoint, endPoint };
        }

        public Point BezierPoint(Point p0, Point p1, Point p2, double t)
        {
            Point finalPoint = new Point();
            finalPoint.X = (int)(Math.Pow(1 - t, 2) * p0.X + (1 - t) * 2 * t * p1.X + t * t * p2.X);
            finalPoint.Y = (int)(Math.Pow(1 - t, 2) * p0.Y + (1 - t) * 2 * t * p1.Y + t * t * p2.Y);
            return finalPoint;
        }

        public double GetRandomNumber(double minimum, double maximum)
        {
            return rnd.NextDouble() * (maximum - minimum) + minimum;
        }

        public Vector3 Smooth(Vector3 currViewAngle, Vector3 CalculatedAngle, float smooth)
        {
            Vector3 smoothedVector = CalculatedAngle - currViewAngle;

            if (linearnoisebut.Checked || overaimnoisebut.Checked)
            {
                smoothedVector /= smooth * (float)GetRandomNumber(0.8, 1.2);
                smoothedVector.X *= (float)GetRandomNumber(1 - (noisebar.Value / 10f), 1 + (noisebar.Value / 10f));
                smoothedVector.Y *= (float)GetRandomNumber(1 - (noisebar.Value / 10f), 1 + (noisebar.Value / 10f));
            }
            else
                smoothedVector /= smooth;
            smoothedVector += currViewAngle;

            return smoothedVector;
        }

        private void curvebut_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void overaimbar_Scroll(object sender, EventArgs e)
        {
            overaimpercent.Text = overaimbar.Value+"%";
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            noiselabel.Text = noisebar.Value.ToString();
        }
    }
}
