using System.Globalization;

namespace GeometryCalculator.Validators
{
    public static class ValidatorInputData
    {
        public static double ValidateAndParseToDouble(string input)
        {
            var epsilon = 0.0001;
            if (string.IsNullOrWhiteSpace(input))
                throw new ArgumentException($"Ошибка: введено некорректное значение.");

            var culture = CultureInfo.GetCultureInfo("ru-RU");

            var size = double.TryParse(input, NumberStyles.Any, culture, out double value) ? value : 0;

            if (size < 0)
                throw new ArgumentException("Размер не может быть отрицательным.");

            if (size < epsilon)
                throw new ArgumentException("Размер не может быть равен нулю.");

            return size;
        }
    }
}
