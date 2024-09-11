using static homework_13_09._09.Program.Homework;

namespace homework_13_09._09
{
    internal class Program
    {
        public class Homework
        {
            public delegate void MakeHomework<T>(List<T> input, Action<string> action);

            static public void report(string num) => Console.WriteLine(num + " task: ");

            //task1
            static public void filterGreaterThan10(List<int> input, Action<string> action)
            {
                action("First");
                input.FindAll(x => x > 10).ForEach(x => Console.Write(x + "\t"));
                Console.WriteLine();
            }

            //task2
            static public void add5ToAll(List<int> input, Action<string> action)
            {
                action("Second");
                input.ForEach(x => Console.Write($"{x + 5}\t"));
                Console.WriteLine();
            }

            //task3
            static public void sum(List<int> input, Action<string> action)
            {
                action("Third");
                Console.WriteLine(input.Sum(x => x));
            }

            //task4
            static public void firstEven(List<int> input, Action<string> action)
            {
                action("Fourth");
                int result = input.Find(x => !Convert.ToBoolean(x & 1));
                Console.WriteLine(result != 0 ? $"Number {result} is even" : "No even elements");
            }

            //task5
            static public void CAPS(List<string> input, Action<string> action)
            {
                action("Fifth");
                input.ForEach(x => Console.Write($"{x.ToUpper()} "));
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 1, 2, 3, 5, 7, 11, 13, 17, 19 };
            List<string> strings = new List<string>() { "this", "is", "a", "test", "strings", "list"};

            MakeHomework<int> intHw = filterGreaterThan10;
            intHw += add5ToAll;
            intHw += sum;
            intHw += firstEven;
            MakeHomework<string> strHw = CAPS;

            intHw(list, report);
            if (strHw != null) strHw(strings, report);
        }
    }
}
