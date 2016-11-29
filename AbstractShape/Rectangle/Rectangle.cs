﻿/*= == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == ==
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

        public Rectangle(double x=0, double y=0)
        {
            this.Name = "Rectangle";
            this.apoint.x = x;
            this.apoint.y = y;
            this.area = GetArea();
            this.perimeter = GetPerimeter();
            this.ImagePath = null;
        }

        public override double GetArea()
        {
            area = apoint.x * apoint.y;
            return area;
        }

        public override double GetPerimeter()
        {
            perimeter = (apoint.x * 2) + (apoint.y * 2);
            return perimeter;
        }
    }
}