using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurvesClassLibrary
{
    /// <summary>
    ///  All Bezier Curves must calculate coordinates from a specific
    ///  set of intermediate points and an interval.
    /// </summary>
    public interface IBezierCurve
    {
        PointF[] BezierPoints(Point[] interMediaPoints, float interval);
    }
}