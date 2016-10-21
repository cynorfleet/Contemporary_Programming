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
        private double radius { get; set; }
        private double height { get; set; }

        public Cylinder()
        {
            Name = "Cylinder";
            radius = 0.0;
            volume = GetVolume();
            surfacearea = GetSurfaceArea();
            ImagePath = null;
        }

        public Cylinder(double rad, double[] coord1, double[] coord2)
        {
            Name = "Cylinder";
            radius = rad;
            point[0].x = coord1[0];
            point[0].y = coord1[1];
            point[1].y = coord2[1];
            point[0].active = true;
            point[1].active = true;
            volume = GetVolume();
            surfacearea = GetSurfaceArea();
            ImagePath = null;
        }

        public override double GetSurfaceArea()
        {
            GetDimensions();
            //Get the height
            height = point[1].y - point[0].y;
            try
            {
                surfacearea = 2 * pi * radius * height + (2 * pi * (radius * radius));
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
                volume = pi * (radius * radius) * height;
            }
            catch (System.Exception ex)
            {
                ex.ToString();
            }
            return volume;
        }
    }
}
