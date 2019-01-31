using System;

namespace Tutorial03_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //宣告五個整數的一維陣列
            int[] array = new int[5];

            //宣告六個字串的一維陣列
            string[] stringArray = new string[6];

            //陣列初始化
            int[] array1 = new int[] { 1, 3, 5, 7, 9 };
            string[] weekDays = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };

            //陣列初始化簡寫
            int[] array2 = { 1, 3, 5, 7, 9 };
            string[] weekDays2 = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };

            //可以在不進行初始化的情況下宣告陣列變數，但必須在將陣列指派給變數時使用 new 運算子
            int[] array3;
            array3 = new int[] { 1, 3, 5, 7, 9 };


            //宣告10*10個整數的二維陣列，並給予初始值
            int[,] array6 = new int[10, 10];
            //二維陣列初始化
            int[,] array2D = new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };
            int[,] array2Da = new int[4, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };
            string[,] array2Db = new string[3, 2] { { "one", "two" }, { "three", "four" },
                                        { "five", "six" } };
            //三維陣列初始化
            int[,,] array3D = new int[,,] { { { 1, 2, 3 }, { 4, 5, 6 } },
                                 { { 7, 8, 9 }, { 10, 11, 12 } } };
            int[,,] array3Da = new int[2, 2, 3] { { { 1, 2, 3 }, { 4, 5, 6 } },
                                       { { 7, 8, 9 }, { 10, 11, 12 } } };
            //陣列初始化簡寫
            int[,] array4 = { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };
            //可以在不進行初始化的情況下宣告陣列變數，但必須在將陣列指派給變數時使用 new 運算子
            int[,] array5;
            array5 = new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };

            //下列是具有三個項目的一維陣列宣告，且每個都是整數的一維陣列：
            int[][] jaggedArray = new int[3][];

            //每個項目都是整數的一維陣列。 第一個項目是 5 個整數的陣列、第二個是 4 個整數的陣列，而第三個是 2 個整數的陣列。
            jaggedArray[0] = new int[5];
            jaggedArray[1] = new int[4];
            jaggedArray[2] = new int[2];

            //也可以使用初始設定式將值填入陣列元素，在此情況下，您不需要陣列大小
            jaggedArray[0] = new int[] { 1, 3, 5, 7, 9 };
            jaggedArray[1] = new int[] { 0, 2, 4, 6 };
            jaggedArray[2] = new int[] { 11, 22 };

            //可以在宣告時初始化陣列
            int[][] jaggedArray2 = new int[][]
            {
                new int[] { 1, 3, 5, 7, 9 },
                new int[] { 0, 2, 4, 6 },
                new int[] { 11, 22 }
            };

            //也可以簡寫
            int[][] jaggedArray3 =
            {
                new int[] { 1, 3, 5, 7, 9 },
                new int[] { 0, 2, 4, 6 },
                new int[] { 11, 22 }
            };

            // int一維陣列
            var a = new[] { 1, 10, 100, 1000 };

            // string一維陣列
            var b = new[] { "hello", null, "world" };

            // int多維陣列
            var c = new[]
            {
            new[]{1,2,3,4},
            new[]{5,6,7,8}
            };

            // string多維陣列
            var d = new[]
            {
            new[]{"Luca", "Mads", "Luke", "Dinesh"},
            new[]{"Karen", "Suma", "Frances"}
            };

            //一維陣列操作
            int[] numbers = { 4, 5, 6, 1, 2, 3, -2, -1, 0 };
            //循序取值
            foreach (int i in numbers)
            {
               Console.Write("{0} ", i);
            }
            Console.WriteLine();
            // Output: 4 5 6 1 2 3 -2 -1 0

            //多維陣列操作
            int[,] numbers2D = new int[3, 2] { { 9, 99 }, { 3, 33 }, { 5, 55 } };
            // Or use the short form:
            // int[,] numbers2D = { { 9, 99 }, { 3, 33 }, { 5, 55 } };
            foreach (int i in numbers2D)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();
            // Output: 9 99 3 33 5 55

            //您可以將初始化的一維陣列傳遞至方法。
            int[] theArray = { 1, 3, 5, 7, 9 };
            PrintArray(theArray);
            //或是初始化並傳遞新的陣列
            PrintArray(new int[] { 1, 3, 5, 7, 9 });

            //您可以將初始化的多維陣列傳遞至方法。
            int[,] theArray2 = { { 1, 2 }, { 2, 3 }, { 3, 4 } };
            Print2DArray(theArray2);
            //或是初始化並傳遞新的陣列
            Print2DArray(new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } });



        }

        public static void PrintArray(int[] arr)
        {
            foreach (int i in arr)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();
        }

        public static void Print2DArray(int[,] arr)
        {
            foreach (int i in arr)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();
        }


    }

    
}
