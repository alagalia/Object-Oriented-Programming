using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01HumanStudentWorker
{
    internal class HumanStudentWorker
    {
        private static void Main(string[] args)
        {
            List<Student> lsitStudent = new List<Student>()
            {
                new Student("Ivo", "Prokopiev", 11111),
                new Student("Asq", "Stefanova", 31245),
                new Student("Iskra", "Urumova", 44444),
                new Student("Zlati", "Zlatev", 67895),
                new Student("Encho", "Chakyrov", 34256),
                new Student("Stoil", "Stoilov", 93452),
                new Student("Katq", "Petrova", 71234),
                new Student("Minka", "Furiqta", 69856),
                new Student("Pesho", "Kaskata", 78743),
                new Student("Sami", "Vinkela", 77889)
            };
            lsitStudent = new List<Student>(lsitStudent.OrderBy(s => s.FacultyNumber));

            foreach (var student in lsitStudent)
            {
                Console.WriteLine( student +" Faculty number:"+ student.FacultyNumber);
            }
            Console.WriteLine();

            List<Worker> lsitWorker = new List<Worker>()
            {
                new Worker("Sasho", "Yovkov", 200, 8),
                new Worker("Bash", "Maistora", 1000, 8),
                new Worker("Jelqzko", "Sopata", 600, 8),
                new Worker("Masha", "Grigorova", 1200, 8),
                new Worker("Kyncho", "Minchev", 300, 8),
                new Worker("Pepi", "Dunkov", 160, 8),
                new Worker("Bate", "Goiko", 720, 8),
                new Worker("Marselo", "Mastroiani", 4000, 8),
                new Worker("Jim", "Black", 50, 8),
                new Worker("Sheila", "Max", 670, 8),
            };

            lsitWorker = new List<Worker>(lsitWorker.OrderBy(w => w.MoneyPerHour()));
            foreach (var worker in lsitWorker)
            {
                Console.WriteLine( worker.FirstName+" "+ worker.LastName+" "+ worker);
            }
            Console.WriteLine();


            List<Human> allHumans = new List<Human>();

            lsitStudent.ForEach(student => allHumans.Add(student));
            lsitWorker.ForEach(worker=> allHumans.Add((worker)));

            allHumans= new List<Human>(allHumans.OrderBy(a =>a.FirstName));
            foreach (var human in allHumans)
            {
                Console.WriteLine(human.FirstName+ " "+ human.LastName+" - "+ human.GetType().Name);
            }
        }
    }
}
