public class Program
{
    static void Main(string[] args)
    {
        int x = 3;

        int y = 2;

        string[,] AdressBook = new string[3, 2]
        {
            { "Pushkin R.T.", "+79185846958" },
            { "Petrov V.L.", "+79995472534" },
            { "Sidirov K.N.", "zayac@gmail.com" }
        };

        Console.WriteLine("ФИО         Телефон, e-mail");
        for (int i = 0; i < AdressBook.GetLength(0); i++)
        {
            for (int j = 0; j < AdressBook.GetLength(1); j++)
            {
                Console.Write(AdressBook[i, j]);
            }
            Console.WriteLine();
        }
        Console.ReadLine();
    }
}

    
