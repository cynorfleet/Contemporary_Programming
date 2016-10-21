/*= == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == ==
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

using System;

namespace TheCoolestShapes
{
    public abstract class a2DShape : Shape
    {
        public double perimeter { get; set; }

        public a2DShape()
        {
            Name = "2D Shape";
            point = new Point[4];
        }

        public double area { get; set; }
        public override string Name { get; set; }

        public virtual void CalcData()
        {
            GetArea();
            GetPerimeter();
        }

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
            CalcData();
            string output = "\nName: " + Name + "\nArea: " + GetArea();
            output += "\nPerimeter: " + GetPerimeter();
            return (output);
        }
    }
}
