using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePingPong
{
    internal class Program
    {
        static readonly int windowHeight = 30;
        static readonly int windowWidth = 100;
        static int positionY = windowHeight / 2;
        static int positionX = 2;
        static int platformLenght = 3;
        static void Main(string[] args)
        {
            Console.SetWindowSize(windowWidth, windowHeight);
            Console.SetBufferSize(windowWidth, windowHeight);
            ConsoleKeyInfo key;
            do
            {
                Borders.DrawBorders(windowWidth, windowHeight);
                Platforms.DrawPlatform1(windowWidth, windowHeight, out key);
            } while (key.Key != ConsoleKey.Escape);
            
            Console.ReadKey();
        }
    }

    class Borders
    {
        public static void DrawBorders(int windowWidth, int windowHeight)
        {
            for (int i = 0; i < windowWidth; i++)
                Console.Write("-");
            for (int i = 1; i < windowHeight - 2; i++)
            {
                Console.Write("|");
                Console.SetCursorPosition(windowWidth - 1, i);
                Console.Write("|");
            }
            for (int i = 0; i < windowWidth; i++)
                Console.Write("-");
        }
    }

    class Platforms
    {
        public static void DrawPlatform1(int windowWidth, int windowHeight, out ConsoleKeyInfo key)
        {

            int positionY = windowHeight / 2;
            int positionX = 2;
            int platformLenght = 3;
            Console.SetCursorPosition(positionX, positionY);
            for(int i = 0; i < platformLenght; i++)
            {
                Console.SetCursorPosition(positionX, positionY + i);
                Console.WriteLine("|");
            }



            key = Console.ReadKey();
            switch (key.Key)
            {
                case ConsoleKey.UpArrow:

                    break;

                case ConsoleKey.DownArrow:

                    break;

                default:
                    break;
            }
        }
    }
}
