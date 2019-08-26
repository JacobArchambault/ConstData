using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstData
{
    class Program
    {
        class MyMathClass
        {
            public const double PI = 3.14;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Const *****\n");
            Console.WriteLine("The value of PI is: {0}", MyMathClass.PI);
            LocalConstStringVariable();

            Console.ReadLine();
        }

        static void LocalConstStringVariable()
        {
            const string fixedStr = "Fixed string Data";
            Console.WriteLine(fixedStr);
        }
    }
}
