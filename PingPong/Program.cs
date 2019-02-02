using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PingPong
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            int width = Console.WindowWidth;
            int height = Console.WindowHeight;
            Point ball = new Point(width/2, height/2, 'O');
            Console.SetCursorPosition(ball.X, ball.Y);
            ball.Display();

           
            while (true)
            {
                if (ball.X >= width - 1)
                    ball.OffsetX = -ball.OffsetX;
                if (ball.X <= 0)
                    ball.OffsetX = -ball.OffsetX;
                if (ball.Y <= 0)
                    ball.OffsetY = -ball.OffsetY;
                if (ball.Y >= height - 1)
                    ball.OffsetY = -ball.OffsetY;

                ball.X += ball.OffsetX;
                ball.Y += ball.OffsetY;
                Console.Clear();
                Console.SetCursorPosition(ball.X, ball.Y);
                ball.Display();

                Thread.Sleep(100);
            }

        }
    }

    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public char Sym { get; set; }
        public int OffsetX { get; set; }
        public int OffsetY { get; set; }

        public Point(int x, int y, char sym)
        {
            X = x;
            Y = y;
            Sym = sym;
            OffsetX = OffsetY = 1;
        }

        public void Display()
        {
            Console.Write(Sym);
        }
    }
}
