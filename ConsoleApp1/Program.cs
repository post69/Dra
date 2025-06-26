using System;
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("It's easy to win forgiveness for being wrong;\r\nbeing right is what gets you into real trouble.\r\nBjarne Stroustrup");
            /*double[] numbers = new double[5];
            Console.WriteLine("Enter 5 numbers:");
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Number {i + 1}: ");
                numbers[i] = Convert.ToDouble(Console.ReadLine());
            }

            double sum = 0, maxNum = numbers[0], minNum = numbers[0];
            foreach (double num in numbers)
            {
                sum += num;
                if (num > maxNum) maxNum = num;
                if (num < minNum) minNum = num;
            }

            Console.WriteLine("\nResults:");
            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Maximum: {maxNum}");
            Console.WriteLine($"Minimum: {minNum}");
        }*//*
            Console.Write("Enter a six number: ");
            string number = Console.ReadLine();
            if (number.Length == 6)
            {
                string reversed = "";
                for (int i = number.Length - 1; i >= 0; i--)
                {
                    reversed += number[i];
                }
                Console.WriteLine($"Reversed: {reversed}");
            }*/
            Console.Write("Enter the start of range: ");
            int start = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the end of range: ");
            int end = Convert.ToInt32(Console.ReadLine());

            int a = 0, b = 1;
            bool first = true;

            Console.Write("Fibonacci numbers: ");
            if (start <= 0)
            {
                Console.Write("0");
                first = false;
            }
            if (start <= 1 && end >= 1)
            {
                Console.Write(first ? "1" : ", 1");
                first = false;
            }

            while (true)
            {
                int next = a + b;
                if (next > end) break;
                if (next >= start)
                {
                    Console.Write(first ? next.ToString() : ",", next);
                    first = false;
                }
                a = b;
                b = next;
            }
            Console.WriteLine();

        }
    }
}
