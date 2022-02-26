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

            Console.WriteLine();
            Console.WriteLine("Remove value from third no key");
            hashtable.Remove(Element.Third);
            foreach (var key in hashtable.Keys)
            {
                Console.WriteLine($"Key: {key}, value: {hashtable[key]}");
            }
        }
    }
}

/* Hashtable
A Hashtable is a collection of key/value pairs that are arranged based on the hash code of the key. 
Or in other words, a Hashtable is used to create a collection which uses a hash table for storage. 
It generally optimized the lookup by calculating the hash code of every key and store into another
basket automatically and when you accessing the value from the hashtable at that time it matches 
the hashcode with the specified key. It is the non-generic type of collection which is defined in 
System.Collections namespace. 

Important Points: 
------------------
1.In Hashtable, the key cannot be null, but value can be.
2.In Hashtable, key objects must be immutable as long as they are used as keys in the Hashtable.
3.The capacity of a Hashtable is the number of elements that Hashtable can hold.
4.A hash function is provided by each key object in the Hashtable.
5.The Hashtable class implements the IDictionary, ICollection, IEnumerable, ISerializable, IDeserializationCallback, and ICloneable interfaces.
6.In hashtable, you can store elements of the same type and of the different types.
7.The elements of hashtable that is a key/value pair are stored in DictionaryEntry, so you can also cast the key/value pairs to a DictionaryEntry.
8.In Hashtable, key must be unique. Duplicate keys are not allowed.
 */