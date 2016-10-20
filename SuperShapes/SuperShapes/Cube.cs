/*= == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == ==
| Class	:		CUBE
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
| Description : This Library provides the blueprint for Cube object
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
    public class Cube : a3DShape
    {
        public Cube()
        {
            Name = "Cube";
            base.apoint.x = 0;
            volume = GetVolume();
            surfacearea = GetSurfaceArea();
            ImagePath = null;
        }

        public Cube(double x = 0.0)
        {
            Name = "Cube";
            base.apoint.x = x;
            volume = GetVolume();
            surfacearea = GetSurfaceArea();
            ImagePath = null;
        }

        public override double GetSurfaceArea()
        {
            surfacearea = (6 * base.apoint.x) * (6 * base.apoint.x);
            return surfacearea;
        }

        public override double GetVolume()
        {
            volume = (base.apoint.x) * (base.apoint.x) * (base.apoint.x);
            return surfacearea;
        }
    }
}
