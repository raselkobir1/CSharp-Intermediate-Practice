using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediate.ClassAndConstructor
{
    partial class Student
    {
        public Student()
        {
            _name =String.Empty;
            _LastName =String.Empty;    
        }
       public string PartialClassExample()
        {
            return "This is partial class part-1";
        }
    }

    partial class Student
    {
        public Student(string name, string lastName)
        {
            _name = name;
            _LastName = lastName;
        }
        private string _name;
        private string _LastName;
        public string GetFullName()
        {
            return _name + " " + _LastName;
        }
    } 
}
