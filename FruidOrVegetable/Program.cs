using System;

namespace Zad4
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            switch (product)
            {
                case "banana":
                    Console.WriteLine("fruid");
                    break;
                case "apple":
                    Console.WriteLine("fruid");
                    break;
                case "kiwi":
                    Console.WriteLine("fruid");
                    break;
                case "cherry":
                    Console.WriteLine("fruid");
                    break;
                case "lemon":
                    Console.WriteLine("fruid");
                    break;
                case "grapes":
                    Console.WriteLine("fruid");
                    break;
                case "tomato":
                    Console.WriteLine("vegetable");
                    break;
                case "cucumber":
                    Console.WriteLine("vegetable");
                    break;
                case "pepper":
                    Console.WriteLine("vegetable");
                    break;
                case "carrot":
                    Console.WriteLine("vegetable");
                    break;
                default:
                    Console.WriteLine("unknown");
                    break;
            }
        }
    }
}
