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
            int x1 = 1;
            int y1 = 3;
            char syml1 = '*';

            Draw(x1, y1, syml1);

            int x2 = 4;
            int y2 = 5;
            char syml2 = '#';

            Draw(x2, y2, syml2);

            Console.ReadLine();
        }

        static void Draw(int x, int y, char syml) {
            Console.SetCursorPosition(x, y);
            Console.Write(syml);
        }
    }
}
