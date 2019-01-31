using System;

namespace Tutorial02_BasicStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            Declarations();
            ConstantDeclarations();
        }

        //區域變數宣告：
        static void Declarations()
        {
            int a;
            int b = 2, c = 3;
            a = 1;
            Console.WriteLine(a + b + c);
        }

        //區域常數宣告：
        static void ConstantDeclarations()
        {
            const float pi = 3.1415927f;
            const int r = 25;
            Console.WriteLine(pi * r * r);
        }


    }




}
