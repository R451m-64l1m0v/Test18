// See https://aka.ms/new-console-template for more information

using GeometryCalculator.Workers;
using GeometryLibrary;


CirculeWorker.CirculeWorking();
TriangleWorker.TriangleWorking();

Console.WriteLine("Hello, World!");


//Второе задание
//SELECT p.ProductName, c.CategoryName
//FROM Products p
//LEFT JOIN ProductCategories pc ON p.ProductID = pc.ProductID
//LEFT JOIN Categories c ON pc.CategoryID = c.CategoryID
