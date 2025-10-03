using System;

namespace Zad9
{
    class Program
    {
        static void Main(string[] args)
        {
            string ticketType = Console.ReadLine();
            byte rows = byte.Parse(Console.ReadLine());
            byte cows = byte.Parse(Console.ReadLine());
            int ticketsAmount = rows * cows;
            switch (ticketType)
            {
                case "Normal":
                    Console.WriteLine($"{ticketsAmount*7.50:F2}");
                    break;
                case "Premiere":
                    Console.WriteLine($"{ticketsAmount * 12.00:F2}");
                    break;
                case "Discount":
                    Console.WriteLine($"{ticketsAmount * 5.00:F2}");
                    break;
                
            }

        }
    }
}
