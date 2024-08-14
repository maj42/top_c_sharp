using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_1__12._08_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //task1();
            //task2();
            task3();
            Console.ReadLine();
        }

        static void task1()
        {
            int num;
            Console.Write("Enter number from 1 to 100: ");
            num = Convert.ToInt32(Console.ReadLine());
            if (num < 1 || num > 100) Console.Write("Not in range!");
            else
            {
                if (num % 3 == 0) Console.Write("Fizz");
                if (num % 5 == 0) Console.Write("Buzz");
                if (num % 3 != 0 && num % 5 != 0) Console.Write(num);
            }
            Console.WriteLine("\n");
        }

        static void task2()
        {
            double first, second;
            Console.WriteLine("Enter 2 numbers. I'll calculate [second] percents of [first]: ");
            first = Convert.ToInt32(Console.ReadLine());
            second = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(first / 100 * second);
        }

        static void task3() 
        {
            int curr, num = 0;
            Console.WriteLine("Enter 4 numbers: ");
            for (int i = 0; i < 4; ++i)
            {
                curr = Convert.ToInt32(Console.ReadLine());
                num += curr * (int)Math.Pow(10, 3 - i);
            }
            Console.WriteLine(num);
        }
    }
}
