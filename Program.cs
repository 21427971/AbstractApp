using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractApp
{
    abstract class MyShape

    {
        public abstract int Area();

     }
    class Rectangle:MyShape
    {
        private int Length;
        private int Width;

        public Rectangle(int ar=0,int ba=0)
        {
            Length = ar;
            Width = ba;
        }
        public override int Area()
        {
            Console.WriteLine("Rectangle class area :");
            return (Length * Width);
        }
        class RectangleTester
        {
            static void Main(string[] args)
            {
                Rectangle r = new Rectangle(10, 7);
                double a = r.Area();
                Console.WriteLine($"Area is {a}");
                Console.ReadKey();
            }
        }

    }
}
