using System;



namespace Leson1
{
     class Program
    {
        enum month
        {
            January,
            February,
            December,
        }
        static void Main(string[] args)
        {
            Console.Write("Write min temp: ");
            string min = Console.ReadLine();
            Console.Write("Write max temp:");
            string max = Console.ReadLine();
            Console.Write("Write month:");
            string n = Console.ReadLine();

            if (((n == Convert.ToString(month.January)) || (n == Convert.ToString(month.December)) || (n == Convert.ToString(month.February))) && (((Convert.ToInt32(min) + Convert.ToInt32(max)) / 2 > 0)))
            {
                Console.WriteLine("rainy weather");
            }
            else Console.WriteLine("Incorrect input");

        }
    }
}


         
            
        
           
        
    


