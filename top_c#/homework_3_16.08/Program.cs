using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_3_16._08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //task1();
            //task2();
            task3();
        }

        static void task1()
        {
            Random rnd = new Random();

            int[] arr = new int[10];
            for (int i = 0; i < arr.Length; ++i)
            {
                arr[i] = rnd.Next(1, 6);
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();

            int even = 0, odd = 0;
            foreach (int i in arr)
            {
                _ = ((i & 1) == 0) ? even++ : odd++;
            }
            int unique = arr.ToHashSet().Count;
            Console.WriteLine($"Even: {even}\nOdd: {odd}\nUnuque: {unique}");
        }

        static void task2()
        {
            Console.WriteLine("Enter string to reverse words: ");
            string inputStr = Console.ReadLine();
            
            StringBuilder sb = new StringBuilder();
            foreach (string word in inputStr.Split())
            {
                foreach (char ch in word.Reverse()) sb.Append(ch);
                sb.Append(" ");
            }
            Console.WriteLine(sb.ToString());
        }

        static void task3()
        {
            Console.WriteLine("Enter string to count vowels: ");
            string inputStr = Console.ReadLine();
            int vowels = 0;
            string vowelsList = "aeiouy";

            foreach (char ch in inputStr.ToLower()) if (vowelsList.Contains(ch)) vowels++;
            Console.WriteLine($"String contains {vowels} vowels");
        }
    }
}
