/*= == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == ==
| Class	:		CIRCLE
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
| Description : This Library provides the blueprint for Circle object
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
    public class Circle : a2DShape
    {
        private const double pi = (double)3.14;
        public double radius { get; set; }

        public Circle()
        {
            Name = "Circle";
            apoint.x = 0.0;
            area = GetArea();
            perimeter = GetPerimeter();
            ImagePath = null;
        }

        public Circle(double rad=0.0, System.String path = "")
        {
            Name = "Circle";
            apoint.x = rad;
            area = GetArea();
            perimeter = GetPerimeter();
            ImagePath = path;
        }

        public override double GetArea()
        {
            area = (double)pi * (apoint.x * apoint.x);
            return area;
        }

        public override double GetPerimeter()
        {
            perimeter = 2 * pi * apoint.x;
            return perimeter;
        }
    }
}
