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
        public double radius { get; set; }

        public Circle(double rad=0)
        {
            this.Name = "Circle";
            this.radius = rad;
            this.area = GetArea();
            this.perimeter = GetPerimeter();
            this.ImagePath = null;
        }

        public override double GetArea()
        {
            area = 3.14 * (radius * radius);
            return area;
        }

        public override double GetPerimeter()
        {
            this.perimeter = 2 * 3.14 * radius ;
            return this.perimeter;
        }

        public override string ToString()
        /*-------------------------------------------- ToString -------------
       |  Function: ToString
       |
       |  Purpose: Provides a data dump of current object
       |
       |  Returns: A string 
       *-------------------------------------------------------------------*/
        {
            string output = "\nName: " + this.Name + "\nRadius: " + radius;
            output += "\nArea: " + area + "\nCircumference: " + perimeter;
            return (output);
        }
    }
}
