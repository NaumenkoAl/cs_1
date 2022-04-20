using System;


namespace Lesson_4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetFullName("Ferrari", "Santa", "Iovovich"));
            Console.WriteLine(GetFullName("Novicov", "Victor", "Igorevich"));
            Console.WriteLine(GetFullName("Sinicha", "Stanislav", "Romanovich"));
        }
        static string GetFullName(string Firstname, string LastName, string patronymic)
        {
            return $"{Firstname} {LastName} {patronymic}";
        }
    }
}

 