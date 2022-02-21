using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediate.AnonomousAndNullableType
{
    public class AnonomousAndNullableTypes
    {
        public void anonomousType()
        {
            var myAnonomousObj = new {Name = "Rasel", Age = "25" };

            var number = 15; // the number is of type int
            var word = "example"; //the word is of type string
            var money = 987.32; //the money is of type double
        }

        public void nullableType() 
        {
            //Nullable Types
            //int number = null; //we get exception
            int? number = null;
            int another = 200;
            number = 345;
            number = another;

            int? number1 = null;
            if (number1.HasValue)
            {
                Console.WriteLine($"number is not null {number1.Value}");
            }
            else
            {
                Console.WriteLine("number is null");

            }
        }
    }
}
