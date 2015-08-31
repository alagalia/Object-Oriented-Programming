using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateGeneric
{
    delegate int GenericDelegat<T>(T value);

    class DelegateGen
    {
        static int PrintSting(string str)
        {
            return int.Parse(str)+4;
        }
        int TestMethos(string str)
        {
            Console.WriteLine("I was called by delegate wtih parameter:{0}", str);
            return int.Parse(str);
        }

        static void Main()
        {
            GenericDelegat<string> parse = DelegateGen.PrintSting;//статичен метод
            //GenericDelegat<string> parse = PrintSting; //съкратен запис 

            parse += new DelegateGen().TestMethos; //инстанционен метод

            parse += delegate(string str) //анонимен метод
            {
                Console.Write("result is: ");
                return int.Parse(str);
            };
            Console.WriteLine(parse("3"));

        }
    }
}
