using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleverDice
{
    class Program
    {
        static void Main(string[] args)
        {
            Welcome();

            Console.ReadLine();

            Console.WriteLine("EOP");
        }

        private static void Welcome()
        {
            Console.Write("Welcome to ");
            var defaultColor = Console.ForegroundColor;

            var colorList = new List<System.ConsoleColor>
            {
                ConsoleColor.White,
                ConsoleColor.Yellow,
                ConsoleColor.Cyan,
                ConsoleColor.Green,
                ConsoleColor.Red,
                ConsoleColor.Magenta
            };

            // Change colors by character
            var titleString = "CLEVERDICE!";
            for (int i = 0; i < titleString.Length; i++)
            {
                Console.ForegroundColor = colorList.ElementAt(i % colorList.Count);
                Console.Write(titleString.Substring(i, 1));
            }

            // Stop this madness
            Console.ForegroundColor = defaultColor;
        }
    }
}
