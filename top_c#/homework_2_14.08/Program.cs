using System;
using System.Linq;

namespace homework_2_14._08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 0, 1, 2, -3, 0, -4, -5, 0 };
            int[,] arr2D = { { 0, 1, 2 }, { 3, 4, 5 }, {6, 7, 8 } };

            //task1(arr);
            //foreach (int i in arr) Console.Write(i + " ");
            //Console.Write("\n");

            //task2(arr);
            //foreach (int i in arr) Console.Write(i + " ");
            //Console.Write("\n");

            //task3(arr);
            //foreach (int i in arr) Console.Write(i + " ");
            //Console.Write("\n");

            //task4(arr2D);
        }

        static void task1(int[] arr)
        {
            int zeroes = 0;
            for (int ind = 0; ind < arr.Length; ++ind)
            {
                if (arr[ind] == 0)
                {
                    zeroes++;
                    continue;
                }
                arr[ind - zeroes] = arr[ind];
            }
            
            for (int ind = arr.Length - 1; ind != arr.Length - 1 - zeroes; --ind)
            {
                arr[ind] = -1;
            }
        }

        static void task2(int[] arr)
        {
            for (int i = 0; i < arr.Length; ++i)
            {
                if (arr[i] >= 0)
                {
                    for (int j = i; j < arr.Length; ++j)
                    {
                        if (arr[j] < 0)
                        {
                            int temp = arr[j];
                            arr[j] = arr[i];
                            arr[i] = temp;
                        }
                    }
                }
            }
        }

        static void task3(int[] arr)
        {
            Console.Write("Enter a number: ");
            int num = 0;
            if (Int32.TryParse(Console.ReadLine(), out num)) {
                Console.WriteLine($"{arr.Where(item => item == num).Count()} numbers {num} in an array");
            }
            else Console.WriteLine("Not a number");
        }

        static void task4(int[,] arr)
        {
            // Before
            for (int i = 0; i < arr.GetLength(0); ++i)
            {
                for (int j = 0; j < arr.GetLength(1); ++j)
                {
                    Console.Write(arr[i,j] + " ");
                }
                Console.Write("\n");
            }
            Console.Write("\n\n");

            // Swap columns 1 and 3
            for (int j = 0; j < arr.GetLength(1); ++j)
            {
                int temp = arr[j, 0];
                arr[j,0] = arr[j,2];
                arr[j, 2] = temp;
            }

            // After
            for (int i = 0; i < arr.GetLength(0); ++i)
            {
                for (int j = 0; j < arr.GetLength(1); ++j)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.Write("\n");
            }
            Console.Write("\n\n");
        }
    }
}
