/*= == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == ==
| Class	:		RECTANGLE
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
| Description : This Library provides the blueprint for Rectangle object
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
    public class Rectangle : a2DShape
    {
        private double length;
        private double width;

        public Rectangle()
        {
            Name = "Rectangle";
            area = GetArea();
            perimeter = GetPerimeter();
            ImagePath = null;
        }
        public Rectangle(double[] coord1, double[] coord2, double[] coord3)
        {
            Name = "Rectangle";
            ImagePath = null;
            point[0].x = coord1[0];
            point[0].y = coord1[1];
            point[1].x = coord2[0];
            point[1].y = coord2[1];
            point[2].x = coord3[0];
            point[2].y = coord3[1];
            // flag active points
            for (var i = 0; i < 3; i++)
                point[i].active = true;

            area = GetArea();
            perimeter = GetPerimeter();
        }

        public override double GetPerimeter()
        {
            GetDimensions();
            // Grab a side from length and width
            length = dimensions[0];
            width = dimensions[1];
            perimeter = (length * 2) + (width * 2);
            return perimeter;
        }

        public override double GetArea()
        {
            GetDimensions();
            // Grab a side from length and width
            length = dimensions[0];
            width = dimensions[1];
            area = length * width;
            return area;
        }
    }
}
