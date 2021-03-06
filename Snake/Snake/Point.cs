﻿using System;
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

        public Point()
        {

        }

        public Point(Point p)
        {
            x = p.x;
            y = p.y;
            syml = p.syml;
        }

        public void Move(int offset, Direction direction)
        {
            if(direction == Direction.RIGHT)
            {
                x = x + offset;
            }
            else if(direction == Direction.LEFT)
            {
                x = x - offset;
            }
            else if(direction == Direction.UP)
            {
                y = y - offset;
            }
            else if(direction == Direction.DOWN)
            {
                y = y + offset;
            }
        }

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

        public void Clear()
        {
            syml = ' ';
            Draw();
        }

        internal bool IsMit(Point p)
        {
            return p.x == this.x && p.y == this.y;
        }
    }
}
