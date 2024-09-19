using GeometryLibrary;

namespace GeometryCalculator.Workers
{
    public static class CirculeService
    {
        public static void CirculeExecute(double radius)
        {
            var circle = new Circle(radius);
            var circleArea = circle.CalculateArea();
            Console.WriteLine($"Площадь круга с радиусом {radius}: {circleArea}");
        }
    }
}
