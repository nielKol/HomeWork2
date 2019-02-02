using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point snake = new Point(Console.WindowWidth / 2, Console.WindowHeight / 2, '@');
            Console.SetCursorPosition(snake.X, snake.Y);
            snake.Display();

            ConsoleKey key;
            do
            {
                key = Console.ReadKey().Key;

                if (key != null)
                {
                    if (key == ConsoleKey.LeftArrow)
                        snake.X--;
                    else if (key == ConsoleKey.RightArrow)
                        snake.X++;
                    else if (key == ConsoleKey.UpArrow)
                        snake.Y--;
                    else if (key == ConsoleKey.DownArrow)
                        snake.Y++;

                    Console.Clear();
                    Console.SetCursorPosition(snake.X, snake.Y);
                    snake.Display();
                }
                

            } while (key != ConsoleKey.Escape);
        }
    }

    class Point
    {
        public int X    { get; set; }
        public int Y    { get; set; }
        public char Sym { get; set; }

        public Point (int x, int y, char sym)
        {
            X = x;
            Y = y;
            Sym = sym;
        }

        public void Display()
        {
            Console.Write(Sym);
        }
    }
}
