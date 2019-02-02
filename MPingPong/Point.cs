using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPingPong
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public char Sym { get; set; }
        

        public Point(int x, int y)
        {
            X = x;
            Y = y;
            Sym = '*';
        }

        public void Display()
        {
            Console.Write(Sym);
        }

    }
}
