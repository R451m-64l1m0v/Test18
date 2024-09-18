using GeometryLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryCalculator.Workers
{
    public static class CirculeWorker
    {
        public static void CirculeWorking()
        {
            Console.Write("Введите радиус круга: ");
            string input = Console.ReadLine();
            if (double.TryParse(input, out double radius))
            {
                if (radius < 0)
                {
                    Console.WriteLine("Радиус не может быть отрицательным.");
                }
                else
                {
                    var circle = new CalculatorCircle(radius);
                    var circleArea = circle.CalculateArea();
                    Console.WriteLine($"Площадь круга с радиусом {radius}: {circleArea}");
                }
            }
            else
            {
                Console.WriteLine("Ошибка: введено некорректное значение.");
            }
        }
    }
}
