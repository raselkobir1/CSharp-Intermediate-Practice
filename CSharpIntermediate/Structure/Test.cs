using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediate.Structure
{
    public class Test
    {
        public int Number { get; set; }
        public Test(int number)
        {
            Number = number;
        }
        public void ChangeNumber(Test test)
        {
            test.Number = 45;
            //Console.WriteLine(test.Number);
        }
    }
}
