using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a class named Point that has x and y coordinates,
//and also has three methods:
//-Move: moves the point to a new position by subtracting 5 from x and adding 5 to y.
//- Quadrant: determines in which quadrant the coordinate point lies.
//- Print: prints the point in the format (x , y).

namespace ExercisesOOP
{
    internal class Point
    {
        private int x;
        private int y;
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public void Move()
        {
            x -= 5;
            y += 5;
        }
        public void Quadrant()
        {
            if (x >= 0 && y >= 0)
            {
                Console.WriteLine("You Are In The First Quarter.");
            }
            else if (x >= 0 && y <= -1)
            {
                Console.WriteLine("You Are In The Second Quarter.");
            }
            else if (x <= -1 && y <= -1)
            {
                Console.WriteLine("You Are In The Third Quarter.");
            }
            else if (x <= -1 && y >= 0)
            {
                Console.WriteLine("You Are In The Fourth Quarter.");
            }
            else
            {
                Console.WriteLine("Input Error ");
            }

        }
        public void Print()
        {
            //Console.WriteLine("(" + x+"," + y + ")"); or:
            Console.WriteLine("({0},{1})", x, y);
        }
    }
}
