using GeometryLibrary.Abstracts;

namespace GeometryLibrary
{
    public class Triangle : Shape
    {
        public double sideA { get; }
        public double sideB { get; }
        public double sideC { get; }

        public Triangle(double a, double b, double c)
        {
            sideA = a;
            sideB = b;
            sideC = c;
        }        

        public override double CalculateArea()
        {
            try
            {
                var semiPerimeter = (sideA + sideB + sideC) / 2;

                var semiPerimeterSideA = (semiPerimeter - sideA);
                var semiPerimeterSideB = (semiPerimeter - sideB);
                var semiPerimeterSideC = (semiPerimeter - sideC);

                var multiplication = semiPerimeter * semiPerimeterSideA * semiPerimeterSideB * semiPerimeterSideC;

                var triangleArea = Math.Sqrt(multiplication);

                return triangleArea;
            }
            catch (Exception)
            {
                throw;
            }
        }
        
        public bool IsRightTriangle()
        {
            try
            {
                var epsilon = 0;
                var sides = new List<double> { sideA, sideB, sideC };
                sides.Sort();

                var squareLeg1 = Math.Pow(sides[0], 2);
                var squareLeg2 = Math.Pow(sides[1], 2);
                var sumSquaresLegs = squareLeg1 + squareLeg2;
                var squareHypotenuse = Math.Pow(sides[2], 2);
                
                return Math.Abs(sumSquaresLegs - squareHypotenuse) == epsilon ? true : false;                
            }
            catch (Exception)
            {
                throw;
            }        
        }
    }
}
