using System;
using Figures;
namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            //demo circle area
            Circle circ = new Circle(2);
            Console.WriteLine(circ.ToString());

            //demo triangle area and default type 
            Triangle tri = new Triangle(12, 12, 2);
            Console.WriteLine(tri.ToString());

            //demo triangle area and right type 
            Triangle rtri = new Triangle(3, 4, 5);
            Console.WriteLine(rtri.ToString());

            //demo unknown circle
            FigureCalc fig1 = new FigureCalc(20);
            Console.WriteLine(fig1.ToString());

            //demo unknown triangle
            FigureCalc fig2 = new FigureCalc(3, 4, 5);
            Console.WriteLine(fig2.ToString());

        }
    }
}
