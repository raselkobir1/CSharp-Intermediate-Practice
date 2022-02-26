using CSharpIntermediate.ClassAndConstructor;
using CSharpIntermediate.Generic;
using CSharpIntermediate.HashTableCollection;
using CSharpIntermediate.Inheritance;
using CSharpIntermediate.Interface;
using CSharpIntermediate.PropertyOrAccssoreMethod;
using CSharpIntermediate.QueueCollection;
using CSharpIntermediate.StackCollection;
using CSharpIntermediate.StaticClassAndMethod;
using CSharpIntermediate.Structure;
using System;
using Student = CSharpIntermediate.ClassAndConstructor.Student;

namespace CSharpIntermediate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();  //default constructor
            Student student1 = new Student("Rasel", "Kabir");  // constructor overloading

            Console.WriteLine(student1.GetFullName());
            Console.WriteLine(student1.PartialClassExample());

            //--------------- Properties practice--------------------------------
            StudentProp studentProp = new StudentProp("John", "Doe");
            string name = studentProp.Name; // call to a get block of the name property value
            string lName = studentProp.LastName; 

            studentProp.Name = "David"; // call to a set block of the name property
            studentProp.LastName = "Dauni";

            //----------------------Static class and method 

            string word = "football";
            string newWord = TestClass.FirstLetterUpperCase(word);
            Console.WriteLine(newWord);

            //Extension method and use of extension method
            string word1 = "umbrella".FirstLetterUpperCase(); ;
            Console.WriteLine(word1);
            

            //----------------------STRUCTURE---------------------------
            Console.WriteLine("----------------STRUCTURE--------------");

            Time time = new Time(3, 30, 25);
            time.PrintTime();

            Test test = new Test(10);
            Console.WriteLine(test.Number);

            test.ChangeNumber(test);
            Console.WriteLine(test.Number);

            //result for this class 10 and 45 and its right for class.
            //But if we change our Test class to be a structure and then inspect the result, we will see 10 and 10.

            //----------------------ENUM---------------------------
            Console.WriteLine("----------------ENUM--------------");
            DayOfWeek friday = DayOfWeek.Friday;
            Console.WriteLine(friday);
            Console.WriteLine((int)friday);

            //----------------------Inheritance---------------------------
            Console.WriteLine("----------------Inheritance--------------");
            JSONWriter jSONWriter = new JSONWriter("jsonFileName");
            jSONWriter.FormatJSONFile();
            jSONWriter.Write();

            XMLWriter xMLWriter = new XMLWriter("xmlFileName");
            xMLWriter.Write();
            xMLWriter.FormatXMLFile();

            XMLWriter xml = new XMLWriter("xml writer");
            Writer writer = xml;
            writer.Write();
            //writer.FormatXML();  //error:  FormatXML is not part of writer class

            Writer writer1 = new Writer("Writer");
            //XMLWriter xML = writer1;  //error

            //But we can solve this problem by using the “as” keyword:

            //XMLWriter xMLWriter1 = writer1 as XMLWriter;
            //xMLWriter1.FormatXMLFile();

            //----------------------Interface---------------------------
            Console.WriteLine("----------------Interface--------------");

            XmlWritterIC xmlWritterIC = new XmlWritterIC();
            xmlWritterIC.SetName();
            xmlWritterIC.WriteFile();

            IWriter xmlWIC = new XmlWritterIC();
            xmlWIC.WriteFile();
            //xmlWIC.SetName(); //error - the setName methdo is not part of the Iwriter interface.


            XmlWritterIC xmlFile = new XmlWritterIC();
            JsonWriter jsonWriter = new JsonWriter();

            XmlFileWriter xmlFileWriter = new XmlFileWriter(xmlFile);
            xmlFileWriter.Write();

            xmlFileWriter = new XmlFileWriter(jsonWriter);
            xmlFileWriter.Write();

            //----------------------Generic---------------------------
            Console.WriteLine("----------------Generic--------------");

            CollectionInitializer<int> initilizer = new CollectionInitializer<int>(7);

            initilizer.AddElementsToCollection(5, 8, 7, 6, 3, 9);
            int[] collection = initilizer.RetriveAllElements();
            int number = initilizer.RetriveElementOnIntex(3);

            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine($"Element on the selected index is : {number}");

            KeyValuePair<int, string> keyValuePair = new KeyValuePair<int, string>();
            keyValuePair.Key = 10;
            keyValuePair.Value = "Rasel Kabir";
            keyValuePair.PrintKeyValue();

            Generic.Student s = new Generic.Student
            {
                FirstName = "Rasel",
                LastName = "Kabir"

            };

            StudentInfo<Student> studentInfo = new StudentInfo<Student>();
            studentInfo.GetFullName<Generic.Student>(s);

            //----------------------Queue---------------------------
            Console.WriteLine("\n----------------Queue--------------");
            QueueExample quequ = new QueueExample();
            quequ.GetResultFromQueObject();

            //----------------------Stack---------------------------
            Console.WriteLine("\n----------------Stack--------------");
            StackExample stack = new StackExample();
            stack.GetStackResult();

            //----------------------HashTable---------------------------
            Console.WriteLine("\n----------------HashTable--------------");
            HashTableExaample hashTable = new HashTableExaample();
            hashTable.GetValueFromHashtable();



            Console.ReadLine();
        }
    }
}
