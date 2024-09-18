using GeometryLibrary;

namespace GeometryCalculatorTests
{
    [TestClass]
    public class CircleTests
    {
        [TestMethod]
        public void CircleAreaTest()
        {
            var expectedArea = Math.PI * 25;
            var calculatorCircle = new Circle(5);
            var area = calculatorCircle.CalculateArea();
            Assert.AreEqual(expectedArea, area);
        }
    }
}