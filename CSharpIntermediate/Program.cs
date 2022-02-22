using CSharpIntermediate.ClassAndConstructor;
using CSharpIntermediate.PropertyOrAccssoreMethod;
using CSharpIntermediate.StaticClassAndMethod;
using CSharpIntermediate.Structure;
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


            Console.ReadLine();
        }
    }
}
