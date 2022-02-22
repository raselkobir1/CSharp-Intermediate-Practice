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
        public virtual void CalculateFileSize()
        {
            Console.WriteLine("Calculateing file size in a writer class.");
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
        public override void CalculateFileSize()    //method override
        {
             base.CalculateFileSize();
            Console.WriteLine("Calculate file size of JSON file.");
        }
    }
}

/*------ polymorphism --implement by---------- method hiding and overriding----------------------
 A method that is intended to be overridden is called a virtual method. 
When we talk about overriding and hiding, we need to be clear with those terms. 
The hide means that we want completely to hide the implementation of a method from the base class,
but the override means that we want a different implementation of a method from a base class.
 */

/*
 There are some important rules which we need to follow when declaring polymorphic methods by using the virtual and override keywords:

We can’t declare a virtual method as private. Its purpose is to be exposed to a derived class,
so making it private is meaningless. Similarly, overridden methods can’t be private 
because a derived class can’t change the protection level of a method that it inherits
The signatures of virtual and overridden methods must be identical
We can override only a virtual method. If we try to override a method that has no virtual keyword, we will get an error
If we don’t use the override keyword we are not overriding the method we are just hiding it. If this is the behavior we want, we should use the new keyword
An overridden method is a virtual one as well, so it can be overridden in a further derived class
 */