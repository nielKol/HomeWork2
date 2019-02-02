using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPingPong
{
    class Rect
    {
        public Point P1 { get; set; }
        public Point P2 { get; set; }
        public int OffsetX { get; set; }
        public int OffsetY { get; set; }

        public Rect(Point p1, Point p2)
        {
            P1 = p1;
            P2 = p2;
            OffsetX = OffsetY = 1;
        }

        public void Display()
        {
            for(int x = P1.X; x<=P2.X; x++)
            {
                for(int y = P1.Y; y<=P2.Y; y++)
                {
                    Console.SetCursorPosition(x, y);
                    P1.Display();
                }
            }
        }

        public void Limit(int width, int height)
        {
            if (P2.X >= width - 1)
                OffsetX = -OffsetX;
            if (P1.X <= 0)
                OffsetX = -OffsetX;
            if (P1.Y <= 0)
                OffsetY = -OffsetY;
            if (P2.Y >= height - 1)
                OffsetY = -OffsetY;
        }

        public void Move()
        {
            P1.X += OffsetX;
            P1.Y += OffsetY;
            P2.X += OffsetX;
            P2.Y += OffsetY;
            Console.Clear();
            Display();
        }


    }
}
