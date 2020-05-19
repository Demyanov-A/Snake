using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class VarticalLine : Figure
    {
        public VarticalLine(int x, int yTop, int yBottom, char syml)
        {
            pList = new List<Point>();
            for(int y = yTop; y <= yBottom; y++)
            {
                Point p = new Point(x, y, syml);
                pList.Add(p);
            }
        }

    }
}
