/*= == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == ==
| File:	        Point Class
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
| Description : This Library provides the blueprint to derive a Point
|
| Known Bugs :	IF THE PROGRAM DOES NOT FUNCTION CORRECTLY IN SOME
|				SITUATIONS, DESCRIBE THE SITUATIONS AND PROBLEMS HERE
|				AND EMAIL "cynorfleet@gmail.com" per Christian Norfleet
|
*= == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == */
namespace TheCoolestShapes
{
    public class Point
    {
        

        public Point()
        /*-------------------------------------------- Point ----------------
        |  Function: Point
        |
        |  Purpose: Default constructor which sets x,y,z values;
        *-------------------------------------------------------------------*/ 
        {
            Name = "Point";
            x = 0;
            y = 0;
            z = 0;
            active = false;
        }

        public Point(double x1, double y1, double z1 = 0.0)
        /*-------------------------------------------- Point ---------------
        |  Function: Point
        |
        |  Purpose: Parameterized Constructor w/ y and z as optional
        |
        |  Parameters:
        |	        x1, y1, z1 (IN) -- 3 integers
        |
        |  Returns:  N/A
        *-------------------------------------------------------------------*/ 
        {
            Name = "Point";
            x = x1;
            y = y1;
            z = z1;
            active = false;
        }

        public double x
        /*-------------------------------------------- x --------------------
        |  Purpose: Holds the data for the x-value of a point
        |
        |  Returns: A double representing the x-value of a point
        *-------------------------------------------------------------------*/
        {
            set;
            get;
        }

        public double y
        /*-------------------------------------------- y --------------------
        |  Purpose: Holds the data for the y-value of a point
        |
        |  Returns: A double representing the y-value of a point
        *-------------------------------------------------------------------*/
        {
            set;
            get;
        }

        public double z
        /*-------------------------------------------- z --------------------
        |  Purpose: Holds the data for the z-value of a point
        |
        |  Returns: A double representing the z-value of a point
        *-------------------------------------------------------------------*/
        {
            set;
            get;
        }

        public string Name
        /*-------------------------------------------- Name -----------------
        |  Purpose: Sets/Provides the name ob the object
        |
        |  Returns: A string
        *-------------------------------------------------------------------*/
        {
            set;
            get;
        }

        public bool active
        /*-------------------------------------------- Name -----------------
        |  Purpose: Sets/Provides the name ob the object
        |
        |  Returns: A string
        *-------------------------------------------------------------------*/
        {
            set;
            get;
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
            string output = "\nName: " + Name + "\nX-Value: " + x;
            output += "\nY-Value: " + y + "\nZ-Value: " + z;
            return (output);
        }
    }
}
