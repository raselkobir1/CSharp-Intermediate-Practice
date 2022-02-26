using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediate.StackCollection
{
    public class StackExample
    {
        //STACK : LIFO -> Last in first out.
        public void GetStackResult()
        {
            Stack stack = new Stack();
            stack.Push("Rasel");
            stack.Push("10");
            stack.Push(true);
            stack.Push(null);

            int[] arrCollection = {10,20,30,40,50,100 };
            Stack<int> stackcollection = new Stack<int>();
            foreach (var item in arrCollection) 
            {
                stackcollection.Push(item);
            }
            Console.WriteLine("Stack collection list:");
            foreach (var item in stackcollection)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Stack collection Total count :" + stackcollection.Count());
            //Pop removes the element which was included last in a collection and returns it:
            Console.WriteLine("remove from the item which add last :" + stackcollection.Pop());
            Console.WriteLine("Peck from the item which add last :" + stackcollection.Peek());


        }
    }
}
