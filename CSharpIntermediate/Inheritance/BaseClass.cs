using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediate.Inheritance
{
    public class BaseClass
    {

    }
    public class DerivedClass : BaseClass
    {

    }
    public class DerivedSubClass : DerivedClass
    {

    }
}


/*
 What this means is that DerivedSubClass inherits from the DerivedClass and 
from the BaseClass as well, because DerivedClass inherits from the BaseClass. 
That way, we can share the class features between multiple classes, 
even though the one class can inherit only from one base class.

 */