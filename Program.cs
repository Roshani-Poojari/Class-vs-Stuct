
using System;
using ClassStrucDiff.Models;

namespace ClassStrucDiff
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Class (reference type)
            Student student1 = new Student(1, "Tim");
            Student student2 = student1;
            Console.WriteLine(student1.Name); //Tim
            Console.WriteLine(student2.Name); //Tim
            student2.Name = "Chris";
            Console.WriteLine(student1.Name); //Chris
            Console.WriteLine(student2.Name); //Chris

            Console.WriteLine("--------------------------------");
            // Struct (value type)
            Point point1 = new Point(10, 20);
            Point point2 = point1;
            Console.WriteLine(point1.X + "," + point1.Y); //10,20
            Console.WriteLine(point2.X + "," + point2.Y); //10,20
            point2.X = 30; point2.Y = 50;
            Console.WriteLine(point1.X + "," + point1.Y); //10,20
            Console.WriteLine(point2.X + "," + point2.Y); //30,50

        }
    }
}
/*
class vs struct
A class can inherit from other classes, but a structure cannot.
A class is a reference type,A structure, is a value type.
A class always has a default constructor that is called when an object 
of the class is created. A structure, on the other hand, does not have 
a default constructor by default. However, you can define a default 
constructor in a structure if you need one.

*/