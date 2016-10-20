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
        private const double pi = (double)3.14;

        public Cylinder()
        {
            Name = "Cylinder";
            radius = 0.0;
            base.apoint.y = 0.0;
            volume = GetVolume();
            surfacearea = GetSurfaceArea();
            ImagePath = null;
        }

        public Cylinder(double rad = 0.0, double height = 0.0)
        {
            Name = "Cylinder";
            radius = rad;
            try
            {
                base.apoint.y = height;
            }
            catch (System.Exception ex)
            {
                ex.ToString();
            }
            volume = GetVolume();
            surfacearea = GetSurfaceArea();
            ImagePath = null;
        }

        public double radius { get; private set; }

        public override double GetSurfaceArea()
        {
            try
            {
                surfacearea = 2 * pi * radius * apoint.y + (2 * pi * (radius * radius));
            }
            catch (System.Exception ex)
            {
                ex.ToString();
            }
            
            return surfacearea;
        }
        public override double GetVolume()
        {
            try
            {
                volume = pi * (radius * radius) * apoint.y;
            }
            catch (System.Exception ex)
            {
                ex.ToString();
            }
            return volume;
        }
    }
}
