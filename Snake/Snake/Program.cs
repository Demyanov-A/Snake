using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            //Отрисовка границ игрового поля
            HorizontalLine UpLine = new HorizontalLine(0, 79, 0, '#');
            UpLine.Drow();
            VarticalLine LeftLine = new VarticalLine(0, 0, 24, '#');
            LeftLine.Drow();
            HorizontalLine DownLine = new HorizontalLine(0, 79, 24, '#');
            DownLine.Drow();
            VarticalLine RightLine = new VarticalLine(79, 0, 24, '#');
            RightLine.Drow();

            //Отрисовка точек
            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Drow();

            FoodCreator foodCreator = new FoodCreator(80, 25, '$');
            Point food = foodCreator.CreateFood();
            food.Draw();

            while (true)
            {
                if (snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                }
                else
                {
                    snake.Move();
                }

                Thread.Sleep(300);

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }

            }

        }           
    }
}
