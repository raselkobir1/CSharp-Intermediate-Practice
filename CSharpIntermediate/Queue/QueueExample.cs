using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediate.Queue
{
    public class QueueExample
    {
        public void GetResultFromQueObject()
        {
            Queue<int> queueCollection = new Queue<int>();
            queueCollection.Enqueue(10);
            queueCollection.Enqueue(20);
            queueCollection.Enqueue(30);
            queueCollection.Enqueue(40);
            queueCollection.Enqueue(50);

            Console.WriteLine("Quequ collection :");
            foreach (var item in queueCollection)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Total Count :" + queueCollection.Count());
            Console.WriteLine("Remove from top most from queqe : " + queueCollection.Dequeue());
            Console.WriteLine("Peck from top most quequ :" + queueCollection.Peek());

        }
    }
}
