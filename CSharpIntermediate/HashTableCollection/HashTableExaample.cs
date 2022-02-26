using CSharpIntermediate.Enumerations;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediate.HashTableCollection
{
    public class HashTableExaample
    {
        public void GetValueFromHashtable()
        {
            Hashtable hashtable = new Hashtable();
            hashtable.Add(Element.Name, "Rasel kabir");
            hashtable.Add(Element.Second, 120);
            hashtable.Add(Element.Third, 123.68);
            hashtable.Add(Element.Fourth, true); ;

            foreach (var key in hashtable.Keys)
            {
                Console.WriteLine($"Key: {key}, value: {hashtable[key]}");
            }
            Console.WriteLine("Total count of hashtable collection: "+hashtable.Count);

            Console.WriteLine("ContainsKey  determines whether a collection contains a specific key");
            if(hashtable.ContainsKey(Element.Name))
                Console.WriteLine("Name- " +hashtable[Element.Name]);

        }
    }
}
