using GeometryLibrary.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryLibrary
{
    public class CalculatorTriangle : Shape
    {
        private readonly double _a;
        private readonly double _b;
        private readonly double _c;

        public CalculatorTriangle(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
                throw new ArgumentException("Стороны треугольника должны быть положительными");

            _a = a;
            _b = b;
            _c = c;
        }

        public override double CalculateArea()
        {
            try
            {
                var semiPerimeter = (_a + _b + _c) / 2;

                var triangleArea = Math.Sqrt(semiPerimeter * (semiPerimeter - _a) * (semiPerimeter - _b) * (semiPerimeter - _c));
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
                if (_a <= 0 || _b <= 0 || _c <= 0)
                    throw new ArgumentException("Стороны треугольника должны быть положительными");

                var sides = new List<double> { _a, _b, _c };
                sides.Sort();

                if (Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2) == Math.Pow(sides[2], 2))
                {
                    return true;
                }

                return false;
            }
            catch (Exception)
            {
                throw;
            }
            
        }
    }
}
