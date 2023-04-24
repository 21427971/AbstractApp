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

        public Rectangle(int A=0,int B=0)
        {
            Length = A;
            Width = B;
        }
        public override int Area()
        {
            Console.WriteLine("The area of a rectangle is :");
            Console.WriteLine("Enter a length");
            Length = int.Parse(Console.ReadLine());//prompt the user to enter the length and width
            Console.WriteLine("Enter a width");
            Width = int.Parse(Console.ReadLine());
            return (Length * Width);
        }
        class CallRectangle
        {
            static void Main(string[] args)
            {
                Rectangle obj = new Rectangle();
                double a = obj.Area();
                Console.WriteLine($"The area is {a}");
                Console.ReadKey();
            }
        }

    }
}
