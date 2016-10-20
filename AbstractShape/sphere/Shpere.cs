/*= == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == ==
| Class	:		SPHERE
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
| Description : This Library provides the blueprint for Sphere object
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
    public class Shpere : a3DShape
    {
        public Shpere(double rad = 0)
        {
            this.Name = "Sphere";
            this.radius = rad;
            this.volume = GetVolume();
            this.surfacearea = GetSurfaceArea();
            this.ImagePath = null;
        }

        public double radius { get; private set; }

        public override double GetSurfaceArea()
        {
            this.surfacearea = 4 * 3.14 * (radius * radius);
            return this.surfacearea;
        }
        public override double GetVolume()
        {
            this. volume = 4 * 3.14 * ((radius * radius * radius) / 3);
            return this.volume;
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