using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class VarticalLine
    {
        List<Point> pListVert;

        public VarticalLine(int yTop, int yBottom, int x, char syml)
        {
            pListVert = new List<Point>();
            for(int y = yTop; y <= yBottom; y++)
            {
                Point p = new Point(x, y, syml);
                pListVert.Add(p);
            }
        }

        public void Drow()
        {
            foreach(Point p in pListVert)
            {
                p.Draw();
            }
        }
    }
}
