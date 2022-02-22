using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediate.Interface
{

    public class XmlWritterIC : FileBase, IWriter, IFormatter
    {
        public void WriteFile()
        {
            Console.WriteLine("Writing file in the XmlWriter class.");
        }
        public override void SetName()
        {
            base.SetName();
            Console.WriteLine("Setting name in the XmlWriter class.");
        }

        public void FormatFile()
        {
            Console.WriteLine("Formatting file in XmlWriter class.");
        }
    }
    public class JsonWriter : FileBase, IWriter
    {
        public void WriteFile()
        {
            Console.WriteLine("Writing file in the JSON-Writer class.");
        }
        public override void SetName()
        {
            base.SetName();
            Console.WriteLine("Setting name in the JsonWriter class.");
        }
    }


    public class FileBase
    {
        public virtual void SetName()
        {
            Console.WriteLine("Settings name isn the base wiriter class.");
        }
    }
}

