using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CurvesClassLibrary;
using System.Drawing;

namespace KeithHumphreyBezierCurves.Tests
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        ///  Number of points returned by Cubic Bezier Curve calculation
        ///  equals the interval provided.
        /// </summary>
        [TestMethod]
        public void TestMethod1()
        {
            IBezierCurve cubicBezierCurve = CurveFactory.CreateCubicBezierCurve();
            float interval = 10;
            Point[] interMediapoints = new Point[] { new Point { X=0,Y=0 }, new Point { X=1, Y=2 }, new Point { X=2, Y=2 }, new Point { X=4,Y=0 } };
            PointF[] curvePoints = Curves.BezierCurve(cubicBezierCurve, interMediapoints, 1/interval);

            Assert.IsTrue(curvePoints.Length == interval);
        }
    }
}
