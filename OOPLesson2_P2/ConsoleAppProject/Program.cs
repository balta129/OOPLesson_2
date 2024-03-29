using System;
using OOPLesson2_P2.Concrete;

namespace OOPLesson2_P2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Student student1 = new Student(); // Get a new instance / Initialize a class

            student1.Name = "Muhammet"; // Set to a field
            student1.BirthDate = new DateTime(1995, 11, 8); // Set to a field

            Class student1Class = student1.Class; // Get from a property

            Class class1 = new Class(new Student[] { student1 }); // Get a new instance / Initialize a class
            class1.Name = "1A"; // Set to a field

            Class class2 = new Class(new Student[] { student1 }); // Get a new instance / Initialize a class
            class2.Name = "2A"; // Set to a field
            
            
        }
    }
}