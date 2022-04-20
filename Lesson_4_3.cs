using System;

namespace Lesson_4_3
{
    class Programm
    {
        enum season {NaN, Winter, Spring, Summer, Autumn}
        static season OfMonth(int n)
        {
            try
            { 
                if (n <= 0 || n > 12)
                    throw new Exception("Mistake : Put number 1-12");
                switch ((n % 12) / 3)
                {
                    case 0:
                        return season.Winter;
                    case 1:
                        return season.Spring;
                    case 2:
                        return season.Summer;
                    default: return season.Autumn;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return season.NaN;
            }
        }
        static string Season (season s)
        {
            switch (s)
            {
                case season.Winter:
                    return "Winter";
                case season.Spring:
                    return "Spring";
                case season.Summer:
                    return "Summer";
                case season.Autumn:
                    return "Autumn";
                default: return "";
            }
        }
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Put nomber of the month: ");
                Console.WriteLine(Season(OfMonth(Convert.ToInt32(Console.ReadLine()))));
            }
            while (true);
        }
    }
}
