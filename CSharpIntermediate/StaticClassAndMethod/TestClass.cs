using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediate.StaticClassAndMethod
{
    public static class TestClass
    {
        private static int number;
        static TestClass()
        {
            number = 10;
        }

        //Extension Methods and How to Use Them
        public static string FirstLetterUpperCase(string word)
        {
            char letter = Char.ToUpper(word[0]);
            string remaing = word.Substring(1);

            return letter + remaing;
        }
    }
}
