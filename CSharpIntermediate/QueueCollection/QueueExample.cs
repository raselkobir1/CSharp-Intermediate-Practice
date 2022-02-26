using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediate.QueueCollection 
{
    public class QueueExample
    {
        public void GetResultFromQueObject()
        {
            //QUEQU : FIFO -> first in first out

            //not generic
            Queue queue = new Queue();
            queue.Enqueue("Rasel");
            queue.Enqueue(10);
            queue.Enqueue(20.55);
            queue.Enqueue(true);

            //generic collection
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
