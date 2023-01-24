using System;

namespace Figures
{
    public class Figure
    {
        public string type { get; set; }
        public Figure()
        {
            type = "dot";
        }
    }
    /// <summary>
    /// circle figure
    /// </summary>
    public class Circle : Figure
    {
        public double radius { get; set; }
        /// <summary>
        /// define circle
        /// </summary>
        /// <param name="radius"></param>
        public Circle(double radius)
        {
            this.radius = radius;
            type = "Circle";
        }
        /// <summary>
        /// calculate circle area
        /// </summary>
        /// <returns>area</returns>
        public double CalcArea()
        {
            return 3.14 * radius * radius;
        }
        /// <summary>
        /// convert results to string
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Convert.ToString(radius);
        }

    }
    /// <summary>
    /// triangle figure
    /// </summary>
    public class Triangle : Figure
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }
        /// <summary>
        /// returns the type of triangle
        /// </summary>
        /// <param name="SideA">side a</param>
        /// <param name="SideB">side b</param>
        /// <param name="SideC">side c</param>
        /// <returns></returns>
        private string TypeOf(double SideA, double SideB, double SideC)
        {
            if ((SideA * SideA == SideB * SideB + SideC * SideC) || (SideB * SideB == SideA * SideA + SideC * SideC) ||
                                                                                          (SideC * SideC == SideB * SideB + SideA * SideA))
            {
                return "right";
            }
            else
            {
                return "deafault";
            }
        }
        /// <summary>
        /// define triangle
        /// </summary>
        /// <param name="SideA">side a</param>
        /// <param name="SideB">side b</param>
        /// <param name="SideC">side c</param>
        public Triangle(double SideA, double SideB, double SideC)
        {
            this.SideA = SideA;
            this.SideB = SideB;
            this.SideC = SideC;
            type = TypeOf(SideA, SideB, SideC);
        }
        /// <summary>
        /// calculate area of triangle
        /// </summary>
        /// <returns>area</returns>
        public double CalcArea()
        {
            double p = (SideA + SideB + SideC) / 2;
            return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
        }
        /// <summary>
        /// convert results to string
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Convert.ToString($"a = {SideA}, b = {SideB}, c = {SideC}, type = {type}");
        }

    }
    /// <summary>
    /// class for finding area for unknown figure
    /// </summary>
    public class FigureCalc : Figure
    {
        /// <summary>
        /// this is result area
        /// </summary>
        public double result { get; set; }
        /// <summary>
        /// define circle
        /// </summary>
        /// <param name="radius">radius of a circle</param>
        public FigureCalc(double radius)
        {
            Circle circle = new Circle(radius);
            result = circle.CalcArea();
            type = circle.type;
        }
        /// <summary>
        /// define triangle
        /// </summary>
        /// <param name="SideA">side a</param>
        /// <param name="SideB">side b</param>
        /// <param name="SideC">side c</param>
        public FigureCalc(double SideA, double SideB, double SideC)
        {
            Triangle triangle = new Triangle(SideA, SideB, SideC);
            result = triangle.CalcArea();
            type = triangle.type;
        }
        /// <summary>
        /// convert results to string
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"result = {result}, type = {type}";
        }
    }
}
