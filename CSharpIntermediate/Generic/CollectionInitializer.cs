using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediate.Generic
{
    public class CollectionInitializer<T>
    {
        private T[] collection;

        public CollectionInitializer(int collectionLength)
        {
            collection = new T[collectionLength];
        }

        public void AddElementsToCollection(params T[] elements)
        {
            for (int i = 0; i < elements.Length; i++)
            {
                collection[i] = elements[i];
            }
        }
        public T[] RetriveAllElements()
        {
            return collection;
        }
        public T RetriveElementOnIntex(int index)
        {
            return collection[index];
        }
    }
    public class KeyValuePair<TKey, TValue>
    {
        public TKey Key { get; set; }
        public TValue Value { get; set; }

        public void PrintKeyValue()
        {
            Console.WriteLine();
            Console.WriteLine($"Key : {Key}, value : {Value}");
        }
    }
    public class StudentInfo<T> where T : class
    {
        public StudentInfo() 
        {
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void GetFullName<K>(K item)   
        {
            Console.WriteLine($"your Name : {item}");
        }
    }

    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
     


}
