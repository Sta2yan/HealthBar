using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthBar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleColor defaultConsoleColor = Console.ForegroundColor;

            Console.WriteLine("Введите символ закрашивания:");
            char symbolShading = Console.ReadKey(true).KeyChar;
            Console.WriteLine("Введите кол-во жизней в процентах:");
            int percentShading = Convert.ToInt32(Console.ReadLine());

            DrawBar(symbolShading, percentShading, defaultConsoleColor);
        }

        static void DrawBar(char symbol, int percent, ConsoleColor defaultConsoleColor = ConsoleColor.White)
        {
            int fillHealth = percent / 10;
            int maximumHealth = 10;
            char[] symbols = new char[fillHealth];

            Console.Write("[");

            Console.ForegroundColor = ConsoleColor.Red;
            for (int i = 0; i < symbols.Length; i++)
            {
                Console.Write(symbol);
            }

            Console.ForegroundColor = defaultConsoleColor;
            for (int i = fillHealth; i < maximumHealth; i++)
            {
                Console.Write("_");
            }

            Console.Write("]");
        }
    }
}