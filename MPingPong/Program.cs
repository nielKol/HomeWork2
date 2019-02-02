using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MPingPong
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            int width = Console.WindowWidth;
            int height = Console.WindowHeight;
            int m = 12;
            int n = 8;
            Point p1 = new Point(width / 2, height / 2);
            Point p2 = new Point(p1.X+m, p1.Y+n);
            Rect rect = new Rect(p1, p2);

            rect.Display();
            //Console.ReadKey();

            while (true)
            {
                rect.Limit(width, height);
                rect.Move();

                Thread.Sleep(100);
            }

        }
    }

    
}
