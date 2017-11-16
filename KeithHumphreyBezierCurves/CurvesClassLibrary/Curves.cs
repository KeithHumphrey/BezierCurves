using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurvesClassLibrary
{
    /// <summary>
    ///  Curve class can be expanded upon to supply additional functionality for
    ///  all curves.
    /// </summary>
    public class Curves
    {
        /// <summary>
        ///  Returns the points on a Bezier Curve based on the
        ///  intermediate points and interval.
        ///  IBezierCurve supplied to inject and allow polymorphism to determine
        ///  correct points calculation for the curve be it:
        ///  Linear, Quadratic or Cubic.
        /// </summary>
        /// <param name="curve"></param>
        /// <param name="interMediaPoints"></param>
        /// <param name="interval"></param>
        /// <returns>PointF[]</returns>
        public static PointF[] BezierCurve(IBezierCurve curve, Point[] interMediaPoints, float interval)
        {
            PointF[] points = curve.BezierPoints(interMediaPoints, interval);
            return points;
        }
    }
}