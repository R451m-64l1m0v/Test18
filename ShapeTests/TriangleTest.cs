using GeometryLibrary;

namespace GeometryCalculatorTests
{
    [TestClass]
    public class TriangleTest
    {
        [TestMethod]
        public void TriangleAreaTest()
        {
            var expectedArea = 6;
            var triangle = new Triangle(3, 4, 5);
            var area = triangle.CalculateArea();
            Assert.AreEqual(expectedArea, area);
        }

        [TestMethod]
        public void TriangleRightAngledTest()
        {
            var triangle = new Triangle(3, 4, 5);
            var isRightAngled = triangle.IsRightTriangle();
            Assert.IsTrue(isRightAngled);
        }
    }
}
