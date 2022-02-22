using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediate.Interface
{
    public class XmlFileWriter
    {
        private readonly IWriter _writer;
        public XmlFileWriter(IWriter writer)
        {
            _writer = writer; 
        }
        public void Write()
        {
            _writer.WriteFile();
        }
    }
}
