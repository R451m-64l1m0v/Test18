using GeometryLibrary;

namespace GeometryCalculatorTests
{
    [TestClass]
    public class CalculatorCircleTests
    {
        [TestMethod]
        public void CircleAreaTest()
        {
            var expectedArea = Math.PI * 25;
            var calculatorCircle = new CalculatorCircle(5);
            var area = calculatorCircle.CalculateArea();
            Assert.AreEqual(expectedArea, area);
        }
    }
}