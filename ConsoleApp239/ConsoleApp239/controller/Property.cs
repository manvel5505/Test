using ConsoleApp239.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp239.controller
{
    internal class Property : Shapes
    {
        public void Print()
        {
            Console.Write("What shape do you want to Draw? (Rectangle|Triangle): ");
            Shape = Convert.ToString(Console.ReadLine());

            Console.Write("What Color do you like to use for shape? ");
            Color1 = Convert.ToString(Console.ReadLine());
            
            X = 6;

            if (Shape.Equals("Triangle"))
            {
                IFunction function = new Triangle();

                Colors((Color)Enum.Parse(typeof(Color), Color1, ignoreCase: true));
                
                function.Draw(X, Y);

                function.Move();
            }
            if (Shape.Equals("Rectangle"))
            {
                IFunction function = new Rectangle();

                Colors((Color)Enum.Parse(typeof(Color), Color1, ignoreCase: true));
                
                function.Draw(X, Y);

                function.Move();
            }
        }
        public void Colors(Color color)
        {
            switch (color)
            {
                case Color.red:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case Color.green:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case Color.blue:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case Color.yellow:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case Color.white:
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case Color.magenta:
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    break;
            }
        }
    }
}
