using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
   public class DelegateSample
   {
       public delegate void MyDelegat(string param);
        static void TestMethos(string str)
        {
            Console.WriteLine( "I was called by delegate wtih parameter:{0}",str);
        }

        static void TestMethos1(string str)
        {
            Console.WriteLine("I was called by second delegate wtih parameter:{0}", str);
        }

        static void Main(string[] args)
        {
            MyDelegat my = new MyDelegat(TestMethos);
            my += TestMethos1;
            my("Galya");
        }
    }

 
}
