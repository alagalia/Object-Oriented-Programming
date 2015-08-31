using System;
using System.Collections.Generic;

namespace Predicates
{
    class Program
    {
        static void Main()
        {
            Action<int> printNumberAction = Console.WriteLine;
            printNumberAction(10);

            var students = new List<Student>()
            {
                new Student("Pesho", 23),
                new Student("Sasho", 18),
                new Student("Ivan", 34)
            };
            Student ivan = students.FirstOrDef(Hasname);
            Console.WriteLine(ivan.Name + " " + ivan.Age);

            var nums = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            nums.ForEachH();
            var smallNums = nums.TakeWhile(IsSmallerThan);
            Console.WriteLine(String.Join(", ", smallNums));
        }


        //FUNC-s, PREDICATEs <------ they return bool
        static bool Hasname(Student student)//(student => student.Name == "Ivan")
        {
            return student.Name == "Ivan";
        }

        //FUNC-s, PREDICATEs <------ they return bool
        static bool IsSmallerThan(int element)
        {
            return element < 5;
        }
    }
}
