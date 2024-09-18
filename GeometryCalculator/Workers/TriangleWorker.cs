using GeometryLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryCalculator.Workers
{
    public static class TriangleWorker
    {
        public static void TriangleWorking()
        {
            Console.WriteLine("Введите стороны треугольника:");

            Console.Write("Сторона A: ");
            string inputA = Console.ReadLine();
            Console.Write("Сторона B: ");
            string inputB = Console.ReadLine();
            Console.Write("Сторона C: ");
            string inputC = Console.ReadLine();

            if (double.TryParse(inputA, out double a)
                && double.TryParse(inputB, out double b)
                && double.TryParse(inputC, out double c))
            {
                try
                {
                    var triangle = new CalculatorTriangle(a, b, c);
                    var triangleArea = triangle.CalculateArea();
                    Console.WriteLine($"Площадь треугольника со сторонами {a}, {b}, {c}: {triangleArea}");

                    var isRightTriangle = triangle.IsRightTriangle();
                    Console.WriteLine($"Треугольник со сторонами {a}, {b}, {c} является прямоугольным: {isRightTriangle}");
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"Ошибка: {ex.Message}");
                }
            }
            else
            {
                Console.WriteLine("Ошибка: одна или несколько сторон введены некорректно.");
            }
        }
    }
}
