using CSharpIntermediate.ClassAndConstructor;
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
            Console.ReadLine(); 
            

        }
    }
}
