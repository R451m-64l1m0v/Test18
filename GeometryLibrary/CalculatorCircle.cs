using GeometryLibrary.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryLibrary
{
    public class CalculatorCircle : Shape
    {
        private readonly double _radius;

        public CalculatorCircle(double radius)
        {
            if (radius < 0)
                throw new ArgumentException("Радиус не может быть отрицательным");

            _radius = radius;
        }

        public override double CalculateArea()
        {
            var circleArea = Math.PI * Math.Pow(_radius, 2);

            return circleArea;
        }                    
    }
}
