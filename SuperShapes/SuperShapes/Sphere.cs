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
    public class Sphere : a3DShape
    {
        private const double pi = (double)3.14;

        public Sphere()
        {
            Name = "Sphere";
            radius = 0.0;
            volume = GetVolume();
            surfacearea = GetSurfaceArea();
            ImagePath = null;
        }

        public Sphere(double rad = 0.0)
        {
            Name = "Sphere";
            radius = rad;
            volume = GetVolume();
            surfacearea = GetSurfaceArea();
            ImagePath = null;
        }

        public double radius { get; private set; }

        public override double GetSurfaceArea()
        {
            surfacearea = 4 * pi * (radius * radius);
            return surfacearea;
        }
        public override double GetVolume()
        {
            volume = 4 * pi * ((radius * radius * radius) / 3);
            return volume;
        }
    }
}