using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediate.Inheritance
{
    public class Writer
    {
        public string FileName { get; set; }
        public Writer(string fileName)
        {
            FileName = fileName;
        }
        public void Write( ) 
        {
            Console.WriteLine("Writing to a file");
        }
        public void SetName()
        {
            Console.WriteLine("Setting name in the base Writer class");
        }
    }
    //--XML writer class
    public class XMLWriter : Writer
    {
        public XMLWriter(string fileName) : base(fileName)
        {
        }

        public void FormatXMLFile()
        {
            Console.WriteLine("Formating XML file");
        }
        public new void SetName()   //metod hiding.
        {
            Console.WriteLine("Setting name in the XMLWriter class");
        }
    }
    //--JSON writer class
    public class JSONWriter : Writer
    {
        public JSONWriter(string fileName) : base(fileName)
        {
        }

        public void FormatJSONFile()
        {
            Console.WriteLine("Formating JSON file");
        }
  
    }
}

/*------------------ method hiding and overriding----------------------
 A method that is intended to be overridden is called a virtual method. 
When we talk about overriding and hiding, we need to be clear with those terms. 
The hide means that we want completely to hide the implementation of a method from the base class,
but the override means that we want a different implementation of a method from a base class.
 */