/*= == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == ==
| Class	:		CYLINDER
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
| Description :  This Library provides the blueprint for Cylinder object
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
    public class Cylinder : a3DShape
    {
        public Cylinder(double rad = 0, double height = 0)
        {
            this.Name = "Cylinder";
            this.radius = rad;
            this.apoint.y = height;
            this.volume = GetVolume();
            this.surfacearea = GetSurfaceArea();
            this.ImagePath = null;
        }

        public double radius { get; private set; }

        public override double GetSurfaceArea()
        {
            surfacearea = 2 * 3.14 * radius * this.apoint.y + (2 * 3.14 * (radius*radius));
            return surfacearea;
        }
        public override double GetVolume()
        {
            volume = 3.14 * (radius * radius) * this.apoint.y;
            return volume;
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
            output += "\nSurface Area: " + this.surfacearea + "\nVolume: " + this.volume;
            return (output);
        }
    }
}
