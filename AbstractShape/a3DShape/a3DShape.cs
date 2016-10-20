﻿/*= == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == ==
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
            this.Name = "2D Shape";
            this.apoint.x = 0;
            this.apoint.y = 0;
            this.apoint.z = 0;
            this.ImagePath = null;
        }

        public virtual double GetVolume()
        {
            volume = this.apoint.x * this.apoint.y * this.apoint.z;
            return volume;
        }
        public abstract double GetSurfaceArea();
        public override string ToString()
        /*-------------------------------------------- ToString -------------
       |  Function: ToString
       |
       |  Purpose: Provides a data dump of current object
       |
       |  Returns: A string 
       *-------------------------------------------------------------------*/
        {
            string output = "\nName: " + this.Name + "\nX-Value: " + apoint.x;
            output += "\nY-Value: " + apoint.y + "\nZ-Value: " + apoint.z;
            output += "\nVolume: " + volume + "\n Surface Area: " + surfacearea;
            return (output);
        }

        public double volume {get;set;}
        public double surfacearea { get; set; }

        public Point apoint { get; set; }

        public string ImagePath { get; set; }
        public string Name { get; set; }
    }
}