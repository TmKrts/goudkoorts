using System;
using System.Collections.Generic;
using System.Text;

namespace Goudkoorts_Code.View
{
    public class InputView
    {        
        public int GetSwitchNumber()
        {                           
            bool pressed = false;
            int result = 0;
            while (!pressed)
            {
                ConsoleKey input = Console.ReadKey(false).Key;
 
                switch (input)
                {
                    case ConsoleKey.S:
                        result = -1;
                        pressed = true;
                        break;
                    case ConsoleKey.D1:
                        result = 1;
                        pressed = true;
                        break;
                    case ConsoleKey.D2:
                        result = 2;
                        pressed = true;
                        break;
                    case ConsoleKey.D3:
                        result = 3;
                        pressed = true;
                        break;
                    case ConsoleKey.D4:
                        result = 4;
                        pressed = true;
                        break;
                    case ConsoleKey.D5:
                        result = 5;
                        pressed = true;
                        break;
                    default:                        
                        break;
                }
            }
            return result;
        }
    }
}
