using System;

namespace Lesson_3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку : Hello");
            string str = Console.ReadLine();
            char[] s = str.ToCharArray();
            str = "";


            for (int i = s.Length - 1; i >= 0; i--)
            {

                str += s[i];
            }

            Console.WriteLine();
            Console.Write("Result :");
            Console.WriteLine(str);



            Console.ReadLine();
        }
    }    
}