using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KeithHumphreyBezierCurves.Models
{
    public class BezierCurveModel
    {
        [Required(ErrorMessage = "Please enter x value")]
        [Display(Name = "Point 1 - X")]
        public int pointP1_X { get; set; }

        [Required(ErrorMessage = "Please enter y value")]
        [Display(Name = "Point 1 - Y")]
        public int pointP1_Y { get; set; }

        [Required(ErrorMessage = "Please enter x value")]
        [Display(Name = "Point 2 - X")]
        public int pointP2_X { get; set; }

        [Required(ErrorMessage = "Please enter y value")]
        [Display(Name = "Point 2 - Y")]
        public int pointP2_Y { get; set; }

        [Required(ErrorMessage = "Please enter x value")]
        [Display(Name = "Point 3 - X")]
        public int pointP3_X { get; set; }

        [Required(ErrorMessage = "Please enter y value")]
        [Display(Name = "Point 3 - Y")]
        public int pointP3_Y { get; set; }

        [Required(ErrorMessage = "Please enter x value")]
        [Display(Name = "Point 4 - X")]
        public int pointP4_X { get; set; }

        [Required(ErrorMessage = "Please enter y value")]
        [Display(Name = "Point 4 - Y")]
        public int pointP4_Y { get; set; }

        [Required(ErrorMessage = "Please enter interval.")]
        [Display(Name = "Number Of Intervals")]
        [Range(1, 100, ErrorMessage = "Please enter a number between 1 and 100.")]
        public float interval { get; set; }

        public string result { get; set; }
    }
}