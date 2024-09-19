namespace GeometryCalculator.Validators
{
    public static class ValidatorInputData
    {
        public static double ValidateAndParseToDouble(string input)
        {
            var epsilon = 0;
            if (string.IsNullOrWhiteSpace(input))
                throw new ArgumentException($"Ошибка: введено некорректное значение.");

            var size = double.TryParse(input, out double value) ? value : 0;

            if (size < 0)
                throw new ArgumentException("Размер не может быть отрицательным.");            

            if (Math.Abs(size - 0) == epsilon)
                throw new ArgumentException("Размер не может быть равен нулю.");

            return size;
        }
    }
}
