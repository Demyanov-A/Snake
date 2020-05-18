using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Point
    {
        public int x;
        public int y;
        public char syml;

        public Point(int _x, int _y, char _syml)
        {
            x = _x;
            y = _y;
            syml = _syml;
        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(syml);
        }
    }
}
