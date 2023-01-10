using System;

namespace Quantity_Of_Symbols
{
    class Program
    {
        static void PrintLine(string symbol, uint symbolsCount)
        {
            for (int i = 0; i < symbolsCount; i++)
            {
                Console.Write(symbol);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Write the Symbol");
            string symbol = Console.ReadLine();

            Console.WriteLine("Write the Quantity of Simbols");
            uint symbolsCount = uint.Parse(Console.ReadLine());

            PrintLine(symbol, symbolsCount);
            Console.ReadLine();
        }
    }
}
