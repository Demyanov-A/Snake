using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Figure
    {
        protected List<Point> pList;

        public void Draw()
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }
        }

        internal bool IsMit(Figure figure)
        {
            foreach(var p in pList)
            {
                if (figure.IsMit(p))
                {
                    return true;
                }
                return false;
            }
        }

        private bool IsMit(Point point)
        {
            foreach(var p in pList)
            {
                if (p.IsMit(point))
                {
                    return true;
                }
                return false;
            }
        }
    }
}
