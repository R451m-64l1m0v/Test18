using GeometryLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryCalculatorTests
{
    [TestClass]
    public class CalculatorTriangleTest
    {
        [TestMethod]
        public void TriangleAreaTest()
        {
            var expectedArea = 6;
            var triangle = new CalculatorTriangle(3, 4, 5);
            var area = triangle.CalculateArea();
            Assert.AreEqual(expectedArea, area);
        }

        [TestMethod]
        public void TriangleRightAngledTest()
        {
            var triangle = new CalculatorTriangle(3, 4, 5);
            var isRightAngled = triangle.IsRightTriangle();
            Assert.IsTrue(isRightAngled);
        }
    }
}
