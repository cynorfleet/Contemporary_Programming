using System;
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
        private double side;

        public Cube()
        {
            Name = "Cube";
            volume = GetVolume();
            surfacearea = GetSurfaceArea();
            ImagePath = null;
        }

        public Cube(double[] coord1, double[] coord2)
        {
            Name = "Cube";
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
            side = Math.Abs(point[1].y - point[0].y);
            surfacearea = 6 * (side* side);
            return surfacearea;
        }

        public override double GetVolume()
        {
            side = Math.Abs(point[1].y - point[0].y); ;
            volume = side * side * side;
            return volume;
        }
    }
}
