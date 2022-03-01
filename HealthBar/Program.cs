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

            DrawHealthBar(symbolShading, percentShading, defaultConsoleColor);
        }

        static void DrawHealthBar(char symbol, int percent, ConsoleColor defaultConsoleColor = ConsoleColor.White)
        {
            int maximinPercent = 100;

            if (percent >= 0 && percent <= maximinPercent)
            {
                int oneTenthOfPercent = 10;
                int fillHealth = percent / oneTenthOfPercent;
                int maximumHealth = 10;

                Console.Write("[");

                Console.ForegroundColor = ConsoleColor.Red;
                for (int i = 0; i < fillHealth; i++)
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
            else
            {
                Console.WriteLine("Вы вышли за диапозон по процентам!");
            }
        }
    }
}