using CSharpIntermediate.ClassAndConstructor;
using CSharpIntermediate.PropertyOrAccssoreMethod;
using CSharpIntermediate.StaticClassAndMethod;
using System;

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
            Console.ReadLine();  
            

        }
    }
}
