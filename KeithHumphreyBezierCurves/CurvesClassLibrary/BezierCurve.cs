using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace CurvesClassLibrary
{
    // This project can output the Class library as a NuGet Package.
    // To enable this option, right-click on the project and select the Properties menu item. In the Build tab select "Produce outputs on build".

    public class LinearBezierCurve : IBezierCurve
    {
        public LinearBezierCurve()
        {
        }

        /// <summary>
        ///  Bezier points for a Linear Curve, from two intermediate points
        ///  and an interval.
        /// <param name="interMediaPoints"></param>
        /// <param name="step"></param>
        /// <returns>PointF[]</returns>
        public PointF[] BezierPoints(Point[] interMediaPoints, float interval)
        {
            throw new NotImplementedException();
        }
    }

    public class QuadraticBezierCurve : IBezierCurve
    {
        public QuadraticBezierCurve()
        {
        }

        /// <summary>
        ///  Bezier points for a Quadratic Curve, from three intermediate points
        ///  and an interval.
        /// <param name="interMediaPoints"></param>
        /// <param name="interval"></param>
        /// <returns>PointF[]</returns>
        public PointF[] BezierPoints(Point[] interMediaPoints, float interval)
        {
            throw new NotImplementedException();
        }
    }

    public class CubicBezierCurve : IBezierCurve
    {
        public CubicBezierCurve()
        {
        }

        /// <summary>
        ///  Bezier points for a Cubic Curve, from four intermediate points
        ///  and an interval.
        /// </summary>
        /// <param name="interMediaPoints"></param>
        /// <param name="interval"></param>
        /// <returns>PointF[]</returns>
        public PointF[] BezierPoints(Point[] interMediaPoints, float interval)
        {
            Debug.Assert(interMediaPoints.Length == 4);

            List<PointF> points = new List<PointF>();

            Point p1 = interMediaPoints[0];
            Point p2 = interMediaPoints[1];
            Point p3 = interMediaPoints[2];
            Point p4 = interMediaPoints[3];

            for (float t = 0; t <= 1; t += interval)
            {
                PointF p = new PointF();
                float tPower3 = (float)Math.Pow(t, 3);
                float tPower2 = (float)Math.Pow(t, 2);
                float oneMinusT = 1 - t;
                float oneMinusTPower3 = (float)Math.Pow(oneMinusT, 3);
                float oneMinusTPower2 = (float)Math.Pow(oneMinusT, 2);
                p.X = oneMinusTPower3 * p1.X + (3 * oneMinusTPower2 * t * p2.X) + (3 * oneMinusT * tPower2 * p3.X) + tPower3 * p4.X;
                p.Y = oneMinusTPower3 * p1.Y + (3 * oneMinusTPower2 * t * p2.Y) + (3 * oneMinusT * tPower2 * p3.Y) + tPower3 * p4.Y;

                points.Add(p);
            }

            return points.ToArray();
        }
    }
}