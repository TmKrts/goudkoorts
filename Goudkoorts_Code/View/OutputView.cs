﻿using Goudkoorts_Code.Domain;
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
            Console.WriteLine("It is your task to give the miningcart directions to the dock by switching the switches:");
            Console.WriteLine("The first switch can be changed by pressing 1");
            Console.WriteLine("The second switch can be changed by pressing 2");
            Console.WriteLine("The third switch can be changed by pressing 3");
            Console.WriteLine("The fourth switch can be changed by pressing 4");
            Console.WriteLine("The fifth switch can be changed by pressing 5");
            Console.WriteLine();
            Console.WriteLine("> press any key to continue");
            input = Console.ReadKey();
        }

        public void DrawMap(Map map, int score)
        {
            Console.Clear();
            Console.WriteLine("|~~~~~~~~~~~~~~~~|");
            Console.WriteLine("|~~~GOUDKOORTS~~~|");
            Console.WriteLine("|~~~~~~~~~~~~~~~~|");
            Console.WriteLine("");
            Console.WriteLine("Your score: " + score);
            Console.WriteLine();
            foreach (BaseRail baseRail in map.Row1)
            {
                Console.Write(baseRail.Print());
            }
            Console.WriteLine();
            foreach (BaseRail baseRail in map.Row2)
            {
                Console.Write(baseRail.Print());
            }
            Console.WriteLine();
            foreach (BaseRail baseRail in map.Row3)
            {
                Console.Write(baseRail.Print());
            }
            Console.WriteLine();
            foreach (BaseRail baseRail in map.Row4)
            {
                Console.Write(baseRail.Print());
            }
            Console.WriteLine();
            foreach (BaseRail baseRail in map.Row5)
            {
                Console.Write(baseRail.Print());
            }
        }
        public void PrintControls()
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Press 1-5 to switch the switches");
            Console.WriteLine("Or press S to stop");
        }

        public void ShowEndScreen()
        {
            Console.WriteLine("A cart has crashed into another one! You died.");
            Console.WriteLine("Press S to exit");
        }
    }
}
