/*= == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == ==
| File:	        Point1 Class
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
| Description : This Library provides the blueprint to derive a Point1
|
| Known Bugs :	IF THE PROGRAM DOES NOT FUNCTION CORRECTLY IN SOME
|				SITUATIONS, DESCRIBE THE SITUATIONS AND PROBLEMS HERE
|				AND EMAIL "cynorfleet@gmail.com" per Christian Norfleet
|
*= == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheCoolesPoint
{
    public class Point1
    {

        Point1()
        /*-------------------------------------------- Point1 ----------------
        |  Function: Point1
        |
        |  Purpose: Default constructor which sets x,y,z values;
        *-------------------------------------------------------------------*/
        {
            Name = "Point1";
            x = 0;
            y = 0;
            z = 0;
        }

        Point1(int x1, int y1 = 0, int z1 = 0)
        /*-------------------------------------------- Point1 ---------------
        |  Function: Point1
        |
        |  Purpose: Parameterized Constructor w/ y and z as optional
        |
        |  Parameters:
        |	        x1, y1, z1 (IN) -- 3 integers
        |
        |  Returns:  N/A
        *-------------------------------------------------------------------*/
        {
            Name = "Point1";
            x = x1;
            y = x1;
            z = x1;
        }

        public double x
        /*-------------------------------------------- x --------------------
        |  Purpose: Holds the data for the x-value of a point
        |
        |  Returns: A double representing the x-value of a point
        *-------------------------------------------------------------------*/
        {
            set { }
            get { return x; }
        }

        public double y
        /*-------------------------------------------- y --------------------
        |  Purpose: Holds the data for the y-value of a point
        |
        |  Returns: A double representing the y-value of a point
        *-------------------------------------------------------------------*/
        {
            set { }
            get { return y; }
        }

        public double z
        /*-------------------------------------------- z --------------------
        |  Purpose: Holds the data for the z-value of a point
        |
        |  Returns: A double representing the z-value of a point
        *-------------------------------------------------------------------*/
        {
            set { }
            get { return z; }
        }

        public string Name
        /*-------------------------------------------- Name -----------------
        |  Purpose: Sets/Provides the name ob the object
        |
        |  Returns: A string
        *-------------------------------------------------------------------*/
        {
            set { }
            get { return Name; }
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
            string output = "\nName: " + Name + "\nX-Value: " + this.x;
            output += "\nY-Value: " + this.y + "\nZ-Value: " + this.z;
            return (output);
        }
    }
}
