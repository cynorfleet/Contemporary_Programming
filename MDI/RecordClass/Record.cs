/*= == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == ==
| Class	:		RECORDCLASS
|
| Author :		Christian Norfleet
|
| Language :	CS
|
| Class :		Contemporary Programming
|
| Instructor :	Dr. Stringfellow
|
| Due Date :	12/6/2016
|
+---------------------------------------------------------------------------- -
|
| Description : This class is a Record data-type which will hold inventory data
|               for a private practice. It will contain attributes:
|               Name of practice (Practice),
|               Product ID (ID),
|               Quantity required of product (QtyReq),
|               Quantity in stock (Quantity).
|
| Required Features Not Included : N/A
|
| Known Bugs :	IF THE PROGRAM DOES NOT FUNCTION CORRECTLY IN SOME
|				SITUATIONS, DESCRIBE THE SITUATIONS AND PROBLEMS HERE
|				AND EMAIL "cynorfleet@gmail.com" per Christian Norfleet
|
*= == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace RecordClass
{
    [Serializable]
    public class Record
    {
        public Record()
        {
            /*-------------------------------------------- Record ----------
            |  Function: 	Default constructor
            |
            |  Purpose: 	Initializes attributes
            |
            |  Returns:  	N/A
            *---------------------------------------------------------------------*/
            ID = 0;
            Name = string.Empty;
            QtyReq = 0.0;
            Quantity = 0;
            Practice = string.Empty;
        }

        public Record(int id, string name, string practice, int qtyReq, int quantity)
        {
            /*-------------------------------------------- Record ----------
            |  Function: 	Default constructor
            |
            |  Purpose: 	Initializes attributes
            |
            |  Returns:  	N/A
            *---------------------------------------------------------------------*/
            ID = id;
            Name = name;
            QtyReq = qtyReq;
            Quantity = quantity;
            Practice = practice;
        }

        public Record(SerializationInfo info, StreamingContext ctxt)
        {
            /*-------------------------------------------- Employee ----------
            |  Function: 	Employee()
            |
            |  Purpose: 	Get the values from info and assign them to the appropriate properties
            |
            |  Returns:  	N/A
            *---------------------------------------------------------------------*/
            ID = (int)info.GetValue("ID", typeof(int));
            Name = (String)info.GetValue("Name", typeof(string));
            QtyReq = (double)info.GetValue("Quantity Required", typeof(double));
            Quantity = (int)info.GetValue("Quantity", typeof(int));
        }

        //              Attributes              //
        public int ID { get; set; }

        public string Name { get; set; }

        public string Practice { get; set; }

        public double QtyReq { get; set; }

        public int Quantity { get; set; }

        public void Clear()
        {
            ID = 0;
            Name = string.Empty;
            QtyReq = 0.0;
            Quantity = 0;
            Practice = string.Empty;
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            /*-------------------------------------------- GetObjectData ----------
            |  Function: 	GetObjectData()
            |
            |  Purpose: 	Serialization function
            |
            |  Returns:  	N/A
            *---------------------------------------------------------------------*/
            info.AddValue("ID", ID);
            info.AddValue("Name", Name);
            info.AddValue("Quantity Required", QtyReq);
            info.AddValue("Quantity", Quantity);
        }

        public override string ToString()
        {
            /*-------------------------------------------- ToString ----------
            |  Function: 	ToString()
            |
            |  Purpose: 	Data dump of record in string format
            |
            |  Returns:  	one string
            *---------------------------------------------------------------------*/
            return (ID + "\n" + Name
                + "\n" + QtyReq
                + "\n " + Quantity + "\n");
        }
    }
}