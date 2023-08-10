using ConsoleApp239.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp239.controller
{
    internal class Rectangle : Property, IFunction
    {
        void IFunction.Draw(int x, int y)
        {
            y = x;

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.Write("@");
                }
                Console.WriteLine();
            }
        }
        void IFunction.Move()
        {
            X = Console.WindowWidth / 2 - 1;
            Y = Console.WindowHeight / 2 - 1;

            Console.CursorVisible = false;

            while (true)
            {
                if (Console.KeyAvailable)
                {
                    TupCaract();

                    switch (Console.ReadKey(intercept: true).Key)
                    {
                        case ConsoleKey.UpArrow:
                        case ConsoleKey.W:
                            Y = Math.Max(0, Y - 1);
                            break;
                        case ConsoleKey.LeftArrow:
                        case ConsoleKey.A:
                            X = Math.Max(0, X - 1);
                            break;
                        case ConsoleKey.DownArrow:
                        case ConsoleKey.S:
                            Y = Math.Min(Console.WindowHeight - 1, Y + 1);
                            break;
                        case ConsoleKey.RightArrow:
                        case ConsoleKey.D:
                            X = Math.Min(Console.WindowWidth - 1, X + 1);
                            break;
                        case ConsoleKey.Escape:
                            return;
                    }
                    Console.Clear();

                    DrawC();
                }
            }
        }
        public void DrawC()
        {
            Console.SetCursorPosition(X, Y);
            Console.Write("@@@@@@");
            Console.SetCursorPosition(X,Y  + 1);
            Console.Write("@@@@@@");
            Console.SetCursorPosition(X,Y  + 2);
            Console.Write("@@@@@@");
            Console.SetCursorPosition(X,Y  + 3);
            Console.Write("@@@@@@");
            Console.SetCursorPosition(X,Y  + 4);
            Console.Write("@@@@@@");
        }
        public void TupCaract()
        {
            Console.SetCursorPosition(X, Y);
            Console.Write("       ");
            Console.SetCursorPosition(X, Y + 1);
            Console.Write("       ");
            Console.SetCursorPosition(X, Y + 2);
            Console.Write("       ");
            Console.SetCursorPosition(X, Y + 3);
            Console.Write("       "); 
            Console.SetCursorPosition(X, Y + 4);
            Console.Write("       ");
        }
    }
}
