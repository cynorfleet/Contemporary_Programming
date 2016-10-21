/*= == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == 
| File:	        ABSTRACTSHAPE class
|
| Author :		Christian Norfleet			
|
| Language :	C#
|
| Class :		Contemporary Programming
|
| Instructor :	Dr. Stringfellow
|
| Due Date :	20Oct2016
|
+---------------------------------------------------------------------------- -
|
| Description : This Library provides the blueprint to derive a Shape
|
| Required Features Not Included : A child class that implements interfaced Shape class
|
| Known Bugs :	IF THE PROGRAM DOES NOT FUNCTION CORRECTLY IN SOME
|				SITUATIONS, DESCRIBE THE SITUATIONS AND PROBLEMS HERE
|				AND EMAIL "cynorfleet@gmail.com" per Christian Norfleet
|
*= == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == */
using System;

namespace TheCoolestShapes
{
    public abstract class Shape
    {
        public double[] dimensions = new double[2];

        // return Shape's name
        public abstract string Name
        { set; get; }

        // return Image Path to object
        public virtual string ImagePath
        { set; get; }

        // Dumps data in object to string
        public abstract override string ToString();

        // Contains point info
        public Point[] point;

        public virtual void GetDimensions()
        {
            // find length and width using algorithm 1
            if (point[0].active && point[1].active)
            {
                dimensions[0] = point[1].x - point[0].x;
                dimensions[1] = point[1].y - point[0].y;
            }
            // find length and width using algorithm 2
            else if (point[0].active && point[2].active)
                dimensions = Absval(point[2], point[0]);
        }
        public double[] Absval(Point first, Point second)
        {
            var xresult = Math.Abs(second.x - first.x);
            var yresult = Math.Abs(second.y - first.y);
            double[] result = { xresult, yresult };
            return result;
        }
    }
}