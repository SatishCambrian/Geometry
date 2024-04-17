using Microsoft.VisualStudio.TestTools.UnitTesting;
using GeometryLibrary;
namespace TestProjectGeometry
{

    [TestClass]
    public class SquareTests
    {
        [TestMethod]
        public void TestArea()
        {
            var square = new Square(5);
            var result = square.CalculateArea();
            Assert.AreEqual(25, result);
        }

        [TestMethod]
        public void TestPerimeter() 
        {
            var square = new Square(5);
            var result = square.CalculatePerimeter();
            Assert.AreEqual(20, result);
        }
    }
    [TestClass]
    public class RectangleTests()
    {
        [TestMethod]
        public void TestArea() {
            var rectangle = new Rectangle(10, 5);
            var result = rectangle.CalculateArea();
            Assert.AreEqual(50, result);
        }

        [TestMethod]
        public void TestPerimeter() 
        {
            var rectangle = new Rectangle(10, 5);
            var result= rectangle.CalculatePerimeter();
            Assert.AreEqual(30, result);
        }

    }
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void TestArea() 
        {
            var trianlge = new Triangle(10, 5, 8, 7);
            var result = trianlge.CalculateArea();
            Assert.AreEqual(25, result);
        }

        [TestMethod]
        public void TestPerimeter()
        {
            var triangle = new Triangle(10, 5, 8, 7);
            var result = triangle.CalculatePerimeter();
            Assert.AreEqual(25, result);
        }
    }
}