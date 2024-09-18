using GeometryCalculator.Validators;
using GeometryCalculator.Workers;
using GeometryLibrary;

bool isValid = false;

do
{
    try
    {
        Console.Write("Введите радиус круга: ");
        string input = Console.ReadLine();
        var radius = ValidatorInputData.ValidateAndParseToDouble(input);

        CirculeService.Circule(radius);

        isValid = true; 
    }
    catch (ArgumentException ex)
    {
        Console.WriteLine(ex.Message);
    }
} while (!isValid);

do
{
    try
    {
        isValid = false;
        Console.Write("Сторона A: ");
        string inputA = Console.ReadLine();        
        var sideA = ValidatorInputData.ValidateAndParseToDouble(inputA);

        Console.Write("Сторона B: ");
        string inputB = Console.ReadLine();
        var sideB = ValidatorInputData.ValidateAndParseToDouble(inputB);

        Console.Write("Сторона C: ");
        string inputC = Console.ReadLine();
        var sideC = ValidatorInputData.ValidateAndParseToDouble(inputC);

        var triangle = new Triangle(sideA, sideB, sideC);

        TriangleService.Triangle(triangle);

        isValid = true;
    }
    catch (ArgumentException ex)
    {
        Console.WriteLine(ex.Message);
    }
} while (!isValid);

Console.ReadKey();