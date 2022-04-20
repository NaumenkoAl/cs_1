using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            SPF();
            string data = RecieveData();
            List<string> parts = SplitData(data);
            List<int> numbers = TransformData(parts);
            int result = CalculateData(numbers);
            DisplayResult(result);
        }

        private static void SPF()
        {
            Console.WriteLine();
        }

        private static string RecieveData()
        {
            Console.Write("Put in:");
            return Console.ReadLine();
        }

        private static List<string> SplitData(string data)
        {
            List<string> parts = new List<string>();
            if (string.IsNullOrEmpty(data))
            {
                return parts;
            }
            parts.AddRange(data.Split(' '));
            return parts;
        }

        private static List<int> TransformData (List<string> parts)
        {
            List<int> numbers = new List<int>();
            foreach (var part in parts)
            {
                if (int.TryParse(part, out int number))
                {
                    numbers.Add(number);
                }
            }
            return numbers;
        }

        private static int CalculateData (List<int> numbers)
        {
            int result = 0;
            foreach (var number in numbers)
            {
                result += number; 
            }
            return result;
        }

        private static void DisplayResult (int result)
        {
            Console.WriteLine("Total numbers: " + result);
        }
    }
}
