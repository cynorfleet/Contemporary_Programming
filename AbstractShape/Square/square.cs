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
    public class Square : Rectangle
    {
        public Square(double x=0)
        {
            this.Name = "Square";
            this.apoint.x = x;
            this.area = GetArea();
            this.perimeter = GetPerimeter();
            this.ImagePath = null;
        }

        public override double GetArea()
        {
            area = apoint.x * 2;
            return area;
        }

        public override double GetPerimeter()
        {
            area = apoint.x * 4;
            return area;
        }
    }
}
