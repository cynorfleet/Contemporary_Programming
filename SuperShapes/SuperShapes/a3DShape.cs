/*= == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == ==
| Class	:		A3DSHAPE
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
| Description : This Library provides the blueprint for Rectangle object
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
    public abstract class a3DShape : Shape
    {
        public a3DShape()
        {
            Name = "3D Shape";
            point = new Point[4];
        }
        public virtual void CalcData()
        {
            GetSurfaceArea();
            GetVolume();
        }

        public abstract double GetVolume();
        public abstract double GetSurfaceArea();

        public double volume {get;set;}
        public double surfacearea { get; set; }

        public override string Name { get; set; }

        public override string ToString()
        /*-------------------------------------------- ToString -------------
       |  Function: ToString
       |
       |  Purpose: Provides a data dump of current object
       |
       |  Returns: A string 
       *-------------------------------------------------------------------*/
        {
            CalcData();
            string output = "\nName: " + Name;
            output += "\nSurface Area: " + GetSurfaceArea() + "\nVolume: " + GetVolume();
            return (output);
        }
    }
}
