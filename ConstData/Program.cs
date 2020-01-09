using System;

namespace ConstData
{
    class Program
    {
        class MyMathClass
        {
            public static readonly double PI;
            static MyMathClass()
            { PI = 3.14; }
        }
        static void Main()
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
