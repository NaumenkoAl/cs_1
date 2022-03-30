using System;
 class Program
{
    public static void Main()
    {
        Console.WriteLine("Put number: ");
        int a = int.Parse(Console.ReadLine());
        int k = 1;
        int[,] mas = new int[a, a];
        for (int i = 0; i < a; i++)
        {
            for (int j = 0; j < a; j++)
            {
                if (i == j) mas[i, j] = k;
                Console.Write(mas[i, j] + "  ");
            }
            k++;
            Console.WriteLine();
        }
        Console.ReadLine();
    }
}
