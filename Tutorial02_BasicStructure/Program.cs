using System;
using System.IO;

namespace Tutorial02_BasicStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] weekDays2 = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };

            Declarations();
            ConstantDeclarations();
            SwitchStatement(weekDays2);
            ForEachStatement(new string[]{ "XX", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" });
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

        //運算式陳述式：
        static void Expressions()
        {
            int i;
            i = 123;                // Expression statement
            Console.WriteLine(i);   // Expression statement
            i++;                    // Expression statement
            Console.WriteLine(i);   // Expression statement
        }

        //if 陳述式：
        static void IfStatement(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("No arguments");
            }
            else
            {
                Console.WriteLine("One or more arguments");
            }
        }

        //switch 陳述式：
        static void SwitchStatement(string[] args)
        {
            int n = args.Length;
            switch (n)
            {
                case 0:
                    Console.WriteLine("No arguments");
                    break;
                case 1:
                    Console.WriteLine("One argument");
                    break;
                default:
                    Console.WriteLine($"{n} arguments");
                    break;
            }
        }

        //while 陳述式：
        static void WhileStatement(string[] args)
        {
            int i = 0;
            while (i < args.Length)
            {
                Console.WriteLine(args[i]);
                i++;
            }
        }

        //do 陳述式：
        static void DoStatement(string[] args)
        {
            string s;
            do
            {
                s = Console.ReadLine();
                Console.WriteLine(s);
            } while (!string.IsNullOrEmpty(s));
        }

        //for 陳述式：
        static void ForStatement(string[] args)
        {
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine(args[i]);
            }
        }

        //foreach 陳述式：
        static void ForEachStatement(string[] args)
        {
            foreach (string s in args)
            {
                Console.WriteLine(s);
            }
        }

        //break 陳述式：
        static void BreakStatement(string[] args)
        {
            while (true)
            {
                string s = Console.ReadLine();
                if (string.IsNullOrEmpty(s))
                    break;
                Console.WriteLine(s);
            }
        }

        //continue 陳述式：
        static void ContinueStatement(string[] args)
        {
            for (int i = 0; i < args.Length; i++)
            {
                if (args[i].StartsWith("/"))
                    continue;
                Console.WriteLine(args[i]);
            }
        }

        //goto 陳述式：
        static void GoToStatement(string[] args)
        {
            int i = 0;
            goto check;
        loop:
            Console.WriteLine(args[i++]);
        check:
            if (i < args.Length)
                goto loop;
        }

        //return 陳述式：
        static int Add(int a, int b)
        {
            return a + b;
        }
        static void ReturnStatement(string[] args)
        {
            Console.WriteLine(Add(1, 2));
            return;
        }

        //yield 陳述式：
        static System.Collections.Generic.IEnumerable<int> Range(int from, int to)
        {
            for (int i = from; i < to; i++)
            {
                yield return i;
            }
            yield break;
        }
        static void YieldStatement(string[] args)
        {
            foreach (int i in Range(-10, 10))
            {
                Console.WriteLine(i);
            }
        }

        //throw 陳述式和 try 陳述式：
        static double Divide(double x, double y)
        {
            if (y == 0)
                throw new DivideByZeroException();
            return x / y;
        }
        static void TryCatch(string[] args)
        {
            try
            {
                if (args.Length != 2)
                {
                    throw new InvalidOperationException("Two numbers required");
                }
                double x = double.Parse(args[0]);
                double y = double.Parse(args[1]);
                Console.WriteLine(Divide(x, y));
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Good bye!");
            }
        }

        //checked 和 unchecked 陳述式：
        static void CheckedUnchecked(string[] args)
        {
            int x = int.MaxValue;
            unchecked
            {
                Console.WriteLine(x + 1);  // Overflow
            }
            checked
            {
                Console.WriteLine(x + 1);  // Exception
            }
        }

        //lock 陳述式：
        class Account
        {
            decimal balance;
            private readonly object sync = new object();
            public void Withdraw(decimal amount)
            {
                lock (sync)
                {
                    if (amount > balance)
                    {
                        throw new Exception(
                            "Insufficient funds");
                    }
                    balance -= amount;
                }
            }
        }

        //using 陳述式：using陳述式可以用來簡化try{} finally{} 區塊，但並不包含 catch 的部分使用using 
        //最主要的目的是為了讓物件建立的同時能確保該物件所佔用的資源一定會被完整釋放
        static void UsingStatement(string[] args)
        {
            using (TextWriter w = File.CreateText("test.txt"))
            {
                w.WriteLine("Line one");
                w.WriteLine("Line two");
                w.WriteLine("Line three");
            }
        }



    }




}
