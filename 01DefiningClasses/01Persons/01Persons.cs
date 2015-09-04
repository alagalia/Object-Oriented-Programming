using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01Persons
{
    class Program
    {
        static void Main(string[] args)
        {
            Person first = new Person(30, "Mike", "mike@abv.bg");
            Console.WriteLine(first);

            Person second = new Person(40, "Jimmy", "jimmy@google.com");
            Console.WriteLine(second);
           

        }

    }
}
