/*= == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == 
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheCoolesPoint;

namespace TheCoolestShapes
{
    public interface Shape
    {
        Point apoint
        { get; set; }

        // return Shape's name
        string Name
        { set; get; }

        string ImagePath
        { set; get; }

        string ToString();
    }
}