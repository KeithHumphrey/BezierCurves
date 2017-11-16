using CurvesClassLibrary;
using KeithHumphreyBezierCurves.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace KeithHumphreyBezierCurves.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        ///  Submit four control points and interval in model.
        /// </summary>
        /// <param name="model"></param>
        /// <returns>BezierCurveModel</returns>
        [HttpPost]
        public ActionResult Index(BezierCurveModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    IBezierCurve cubicBezierCurve = CurveFactory.CreateCubicBezierCurve();

                    Point[] interMediapoints = new Point[] {
                        new Point { X = model.pointP1_X, Y = model.pointP1_Y },
                        new Point { X = model.pointP2_X, Y = model.pointP2_Y },
                        new Point { X = model.pointP3_X, Y = model.pointP3_Y },
                        new Point { X = model.pointP4_X, Y = model.pointP4_Y } };

                    PointF[] result = Curves.BezierCurve(cubicBezierCurve, interMediapoints, 1 / model.interval);
                    model.result = ConvertArrayToString(result);
                }

                return View(model);
            }
            catch(Exception ex)
            {
                throw new Exception("Failed to calculate Bezier Curve.", ex);
            }
        }

        /// <summary>
        ///  Converts array of PointFs to string to show on web page.
        /// </summary>
        /// <param name="array">PointF[]</param>
        /// <returns>string</returns>
        [NonAction]
        private static string ConvertArrayToString(PointF[] array)
        {
            StringBuilder builder = new StringBuilder();
            foreach (PointF value in array)
            {
                builder.Append("X " + value.X.ToString("0.0000") + ",  Y " + value.Y.ToString("0.0000"));
                builder.Append("\r\n");
            }
            return builder.ToString();
            }
        }
}