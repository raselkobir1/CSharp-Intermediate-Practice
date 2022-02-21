using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediate.PropertyOrAccssoreMethod
{
    public class StudentProp
    {
        private string _name;
        private string _lastName;

        public StudentProp(string name, string lastName)
        {
            _name = name;
            _lastName = lastName;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
        public string GetFullName()
        {
            return _name + ' ' + _lastName;
        }
        //Read-Only property
        public string MyFirstName
        {
            get { return _name; }
        }
        //Write-Only property
        public string MyLastName
        {
            set { _lastName = value; }
        }
        //public get and private set property
        public string myName
        {
            get { return _name; }
            private set { _name = value; }
        }
        //Auto-Implemented Properties
        public int MyProperty { get; set; }


        //When we declare the properties like this, the compiler creates a private field for us, which could be accessed only through the property’s get or set accessors.

        //So in our example instead of:
        private string _name1;
        public string Name11
        {
            get { return _name1; }
            set { _name1 = value; }
        }
        //We can just write:
        public string Name1 { get; set; }
    }
}







