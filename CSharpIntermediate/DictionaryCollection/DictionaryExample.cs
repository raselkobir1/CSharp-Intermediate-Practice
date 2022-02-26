using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediate.DictionaryCollection
{
    public class DictionaryExample
    {
        public void GetDictionaryValue()
        {
            Dictionary<string,int> dictionary_name = new Dictionary<string,int>(); 
        }
    }
}


/*
 In C#, Dictionary is a generic collection which is generally used to store key/value pairs. 
The working of Dictionary is quite similar to the non-generic hashtable. 
The advantage of Dictionary is, it is generic type. Dictionary is defined under 
System.Collection.Generic namespace. It is dynamic in nature means the size of the dictionary is 
grows according to the need.

Important Points:
-----------------
The Dictionary class implements the
IDictionary<TKey,TValue> Interface
IReadOnlyCollection<KeyValuePair<TKey,TValue>> Interface
IReadOnlyDictionary<TKey,TValue> Interface
IDictionary Interface
In Dictionary, the key cannot be null, but value can be.
In Dictionary, key must be unique. Duplicate keys are not allowed if you try to use duplicate key then compiler will throw an exception.
In Dictionary, you can only store same types of elements.
The capacity of a Dictionary is the number of elements that Dictionary can hold.
How to create the Dictionary?
Dictionary class has 7 constructors which are used to create the Dictionary, here we only use Dictionary<TKey, TValue>() constructor and if you want to learn more about constructors then refer C# | Dictionary Class.

Dictionary<TKey, TValue>(): This constructor is used to create an instance of the Dictionary<TKey, TValue> class that is empty, has the default initial capacity, and uses the default equality comparer for the key type as follows:
 */