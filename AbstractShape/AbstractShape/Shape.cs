﻿/*= == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == 
| File:	        ABSTRACTSHAPE class
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
| Description : This Library provides the blueprint to derive a Shape
|
| Required Features Not Included : A child class that implements interfaced Shape class
|
| Known Bugs :	IF THE PROGRAM DOES NOT FUNCTION CORRECTLY IN SOME
|				SITUATIONS, DESCRIBE THE SITUATIONS AND PROBLEMS HERE
|				AND EMAIL "cynorfleet@gmail.com" per Christian Norfleet
|
*= == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == */
namespace TheCoolestShapes
{
    public interface Shape
    {
        // holds point info
        Point apoint
        { get; set; }

        // return Shape's name
        string Name
        { set; get; }

        // return Image Path to object
        string ImagePath
        { set; get; }

        // Dumps data in object to string
        string ToString();
    }
}