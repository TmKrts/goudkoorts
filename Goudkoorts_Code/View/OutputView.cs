using Goudkoorts_Code.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Goudkoorts_Code.View
{
    class OutputView
    {
        public void ShowStartScreen()
        {
            ConsoleKeyInfo input;
            Console.Clear();
            Console.WriteLine("Hello and welcome to goudkoort");
            Console.WriteLine("It is your task to give miningcard directions to the dok by switching switches:");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("The red switch can be changed by pressing 1");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("The red switch can be changed by pressing 2");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("The red switch can be changed by pressing 3");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("The red switch can be changed by pressing 4");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("The red switch can be changed by pressing 5");
            Console.WriteLine();
            Console.WriteLine("> press any key to continue");
            input = Console.ReadKey();
            Console.Clear();
        }

        public void DrawMap(Map map, int score)
        {
            Console.Clear();
            Console.WriteLine("GOUDKOORTS");
            Console.WriteLine("Your score: " + 0); //proberen score te binden ;)
            Console.WriteLine();
            foreach (BaseRail baseRail in map.Row1)
            {
                Console.WriteLine(baseRail.Print());
            }

            foreach (BaseRail baseRail in map.Row2)
            {
                Console.WriteLine(baseRail.Print());
            }

            foreach (BaseRail baseRail in map.Row3)
            {
                Console.WriteLine(baseRail.Print());
            }

            foreach (BaseRail baseRail in map.Row4)
            {
                Console.WriteLine(baseRail.Print());
            }

            foreach (BaseRail baseRail in map.Row5)
            {
                Console.WriteLine(baseRail.Print());
            }
        }
    }
}
