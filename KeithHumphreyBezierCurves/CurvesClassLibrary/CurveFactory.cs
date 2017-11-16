using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurvesClassLibrary
{
    public static class CurveFactory
    {
        #region Bezier Curves

        /// <summary>
        ///  Linear Bezier Curve.
        /// </summary>
        /// <returns>IBezierCurve/LinearBezierCurve</returns>
        public static IBezierCurve CreateLinearBezierCurve()
        {
            return new LinearBezierCurve();
        }

        /// <summary>
        ///  Quadratic Bezier Curve.
        /// </summary>
        /// <returns>IBezierCurve/QuadraticBezierCurve</returns>
        public static IBezierCurve CreateQuadraticBezierCurve()
        {
            return new QuadraticBezierCurve();
        }

        /// <summary>
        ///  Cubic Bezier Curve.
        /// </summary>
        /// <returns>IBezierCurve/CubicBezierCurve</returns>
        public static IBezierCurve CreateCubicBezierCurve()
        {
            return new CubicBezierCurve();
        }

        #endregion
    }
}
