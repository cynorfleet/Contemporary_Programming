﻿/*= == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == ==
| Assignment:	ABSTRACTSHAPE
|
| Author :		Christian Norfleet			
|
| Language :	C#
|
| Class :		Contemporary Programming
|
| Instructor :	Dr. Stringfellow
|
| Due Date :	20Oct2016
|
+---------------------------------------------------------------------------- -
|
| Description : This Library provides the blueprint to derive a 2Dshape
|
| Required Features Not Included : A child class that implements this abstract class
|
| Known Bugs :	IF THE PROGRAM DOES NOT FUNCTION CORRECTLY IN SOME
|				SITUATIONS, DESCRIBE THE SITUATIONS AND PROBLEMS HERE
|				AND EMAIL "cynorfleet@gmail.com" per Christian Norfleet
|
*= == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == */
namespace TheCoolestShapes
{
    public abstract class a2DShape : Shape
    {


        public double perimeter { get; set; }

        public Point apoint { get; set; }

        public a2DShape()
        {
            this.Name = "2D Shape";
            this.apoint.x = 0;
            this.apoint.y = 0;
            this.area = 0;
            this.ImagePath = null;
        }

        public double area { get; set; }
        public string ImagePath { get; set; }
        public string Name { get; set; }

        public abstract double GetArea();
        /*-------------------------------------------- GetArea ----------
        |  Function: GetArea
        |
        |  Purpose: Calculates the area of the object
        |
        |  Returns: A double of the calculated area
        *-------------------------------------------------------------------*/
        public abstract double GetPerimeter();
        /*-------------------------------------------- GetPerimeter ----------
        |  Function: GetPerimeter
        |
        |  Purpose:  Calculates the perimeter of the object
        |
        |  Returns:  A double of the calculated perimeter
        *-------------------------------------------------------------------*/

        public override string ToString()
        /*-------------------------------------------- ToString -------------
       |  Function: ToString
       |
       |  Purpose: Provides a data dump of current object
       |
       |  Returns: A string 
       *-------------------------------------------------------------------*/
        {
            string output = "\nName: " + this.Name + "\nX-Value: " + this.apoint.x;
            output += "\nY-Value: " + this.apoint.y + "\nArea: " + area;
            output += "\nPerimeter: " + perimeter;
            return (output);
        }

    }
}
