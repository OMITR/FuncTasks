using System;
using System.Linq;

namespace FunctionTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Task1();
            Task2();
            Task3();
            Task4();
        }

        private static void Task1()
        {
            string phrase = Console.ReadLine();
            string[] words = phrase.Split(" ");
            Action<string> word = words => Console.WriteLine(words);
            for (int i = 0; i < words.Length; i++)
            {
                word(words[i]);
            }
        }

        private static void Task2()
        {
            string str = Console.ReadLine();
            string[] numbers = str.Split(" ");
            Action<string> number = numbers => Console.WriteLine(numbers);
            for (int i = 0; i < numbers.Length; i++)
            {
                number(numbers[i] + " (нет в наличии)");
            }
        }

        private static void Task3()
        {
            int min = 10000;
            string input = Console.ReadLine();
            Func<string, int> parser = n => int.Parse(n);
            int[] numbers = input.Split(new string[] {" "},
            StringSplitOptions.RemoveEmptyEntries)
            .Select(parser).ToArray();
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
            }
            Console.WriteLine(min);
        }

        private static void Task4()
        {
            string input = Console.ReadLine();
            string type = Console.ReadLine();
            Func<string, int> parser = n => int.Parse(n);
            int[] numbers = input.Split(new string[] { " " },
            StringSplitOptions.RemoveEmptyEntries)
            .Select(parser).ToArray();
            for (int i = numbers[0]; i <= numbers[1]; i++)
            {
                if (type == "even" && i % 2 == 0)
                {
                    Console.WriteLine(i);
                }

                else if (type == "odd" && i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
