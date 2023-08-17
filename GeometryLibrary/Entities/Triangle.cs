using GeometryLibrary.Interfaces;

namespace GeometryLibrary.Entities
{
    public class Triangle : IShape
    {
        private double side1;
        private double side2;
        private double side3;

        public Triangle(double side1, double side2, double side3)
        {
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
        }

        public double GetArea()
        {
            double semiPerimeter = (side1 + side2 + side3) / 2;
            return Math.Sqrt(semiPerimeter * (semiPerimeter - side1) * (semiPerimeter - side2) * (semiPerimeter - side3));
        }

        public bool IsRightTriangle()
        {
            return Math.Pow(side1, 2) + Math.Pow(side2, 2) == Math.Pow(side3, 2) ||
                   Math.Pow(side1, 2) + Math.Pow(side3, 2) == Math.Pow(side2, 2) ||
                   Math.Pow(side2, 2) + Math.Pow(side3, 2) == Math.Pow(side1, 2);
        }
    }
}
