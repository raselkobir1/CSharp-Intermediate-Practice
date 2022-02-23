using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediate.AbstractClasses
{
    public abstract class AbstractExampleClasses
    {
        public abstract void Print(string text);
        public void Print1()
        {
            Console.WriteLine("abstruct class can contain abstract and not abstract method");
        }
    }
    public class TestAbstract : AbstractExampleClasses
    {
        public override void Print(string text)
        {
            Console.WriteLine("Abstract class print : "+ text); 
        }
    }
}

/*
 The abstract keyword is used for classes and methods:

Abstract class: is a restricted class that cannot be used to create objects (to access it, it must be inherited from another class).

Abstract method: can only be used in an abstract class, and it does not have a body. The body is provided by the derived class (inherited from).
An abstract class can have both abstract and regular methods:
 */
