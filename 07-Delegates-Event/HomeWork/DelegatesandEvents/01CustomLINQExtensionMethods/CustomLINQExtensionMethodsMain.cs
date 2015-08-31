using System;
using System.Collections.Generic;
using System.Linq;

namespace _01CustomLINQExtensionMethods
{
    static class CustomLinqExtensionMethods 
    {
       
        static void Main()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var newNumbers = numbers.WhereNot(num => num % 2 == 0);
            Console.WriteLine(string.Join(", ", newNumbers));

            List<Student> students = new List<Student>
            {
                new Student("Pesho",3.3),
                new Student("Ivo", 4.6),
                new Student("Ani",3)
            };
            Console.WriteLine("Max grade is: "+ students.Max(s => s.Grade));
        }
    }
}
