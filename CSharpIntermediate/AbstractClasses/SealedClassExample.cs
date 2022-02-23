using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediate.AbstractClasses
{
    public sealed class SealedClassExample
    {
        public void sealidClassPrint()
        {
            Console.WriteLine("This is seild class we can't inherit from other class, only initiate it");
        }
    }

    //public class testSealedClass: SealedClassExample    //we can't inherite it
}
