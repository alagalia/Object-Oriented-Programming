using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousMethod
{
    class AnonymousMethod
    {
        public delegate void MyDelegat(string param);
        static void TestMethos(string str)
        {
            Console.WriteLine("I was called by delegate wtih parameter:{0}", str);
        }

        static void Main(string[] args)
        {
            MyDelegat my = delegate(string str) //анонимен метод
            {
                Console.WriteLine("result is: "+str);
            };
            my("AZ");
        }
    }
}
