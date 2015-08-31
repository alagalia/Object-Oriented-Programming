using System;

namespace _04StudentClass
{
    internal class StudentClassMain
    {
        private static void Main()
        {
            Student student = new Student("Peter", 22);
            student.onChangeProperty+=student_onChangeProperty;

            student.Name = "Pesho";
            student.Age = 10;

        }

        private static void student_onChangeProperty(object sender, ChangePropertyEventArgs args)
        {
            if (args.NewName!=args.OldName)
            {
                Console.WriteLine("{0} in {1} was changed. Old {0}: {2} -> new {0}: {3}", args.PropertyName, sender.GetType().Name, args.OldName, args.NewName);
            }
            if (args.OldAge!=args.NewAge)
            {
                Console.WriteLine("{0} in {1} was changed. Old {0}: {2} -> new {0}: {3}", args.PropertyName, sender.GetType().Name, args.OldName, args.NewName);
            }
            
        }
    }
}