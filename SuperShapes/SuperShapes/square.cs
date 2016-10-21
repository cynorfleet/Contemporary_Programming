using System;
/*= == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == ==
| Class	:		SQUARE
|
| Author :		Christian Norfleet			
|
| Language :	CS
|
| Class :		Contemporary Programming
|
| Instructor :	Dr. Stringfellow
|
| Due Date :	20Oct2016
|
+---------------------------------------------------------------------------- -
|
| Description : This Library provides the blueprint for Square object
|
| Required Features Not Included : A child class that implements this class
|
| Known Bugs :	IF THE PROGRAM DOES NOT FUNCTION CORRECTLY IN SOME
|				SITUATIONS, DESCRIBE THE SITUATIONS AND PROBLEMS HERE
|				AND EMAIL "cynorfleet@gmail.com" per Christian Norfleet
|
*= == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == */
namespace TheCoolestShapes
{
    public class Square : a2DShape
    {
        private double side;

        public Square()
        {
            Name = "Square";
            area = GetArea();
            perimeter = GetPerimeter();
            ImagePath = null;
        }

        public Square(double[] coord1, double[] coord2)
        {
            Name = "Square";
            ImagePath = null;
            point[0].x = coord1[0];
            point[0].y = coord1[1];
            point[1].y = coord2[1];
            point[0].active = true;
            point[1].active = true;
            area = GetArea();
            perimeter = GetPerimeter();
        }

        public override double GetArea()
        {
            GetDimensions();
            // Grab a side from length and width
            side = dimensions[0];
            area = side * side;
            OtherPoints();
            return area;
        }

        public override double GetPerimeter()
        {
            GetDimensions();
            side = dimensions[0];
            perimeter = side * 4;
            OtherPoints();
            return perimeter;
        }

        public void OtherPoints()
        {
            point[1].x = point[0].x + side;
            point[1].y = point[0].y;
            point[2].x = point[1].x;
            point[2].x = point[1].y + side;
            point[3].x = point[2].x - side;
            point[3].x = point[2].y;
        }
    }
}
