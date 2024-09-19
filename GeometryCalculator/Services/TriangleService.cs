using GeometryLibrary;

namespace GeometryCalculator.Workers
{
    public static class TriangleService
    {
        public static void TriangleExecute(Triangle triangle)
        {            
            var triangleArea = triangle.CalculateArea();
            Console.WriteLine($"Площадь треугольника со сторонами {triangle.sideA}, {triangle.sideB}, {triangle.sideC}: {triangleArea}");
            
            var isRightTriangle = triangle.IsRightTriangle();
            Console.WriteLine($"Треугольник со сторонами {triangle.sideA}, {triangle.sideB}, {triangle.sideC} является прямоугольным: {isRightTriangle}");
        }
    }
}
