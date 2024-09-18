using GeometryLibrary.Abstracts;

namespace GeometryLibrary
{
    public class Circle : Shape
    {
        private readonly double _radius;

        public Circle(double radius)
        {
            _radius = radius;
        }

        public override double CalculateArea()
        {
            var radiusQuadrate = Math.Pow(_radius, 2);

            var circleArea = Math.PI * radiusQuadrate;

            return circleArea;
        }                    
    }
}
