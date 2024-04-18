using Microsoft.VisualStudio.TestTools.UnitTesting;
using GeometryLibrary;
namespace TestProjectGeometry
{

    /*Square Test starts here*/

    [TestClass]
    public class SquareTests
    {
        [TestMethod]
        public void TestArea()
        {
            //arrange
            var square = new Square(6);

            //act
            var result = square.CalculateArea();

            //assert
            Assert.AreEqual(36, result);
        }

        [TestMethod]
        public void TestPerimeter() 
        {
            //arrange
            var square = new Square(5);

            //act
            var result = square.CalculatePerimeter();

            //assert
            Assert.AreEqual(20, result);
        }

        [TestMethod]
        public void TestSideIsZero()
        {

            //arrange
            var square = new Square(0);


            //act
            var result_A = square.CalculateArea();
            
            //assert
            Assert.AreEqual(0, result_A);
            
            //act
            var result_P = square.CalculatePerimeter();
            Assert.AreEqual(0,result_P);
        }

        [TestMethod]
        public void TestSideIsTooLarge()
        {
            //arrange
            var square = new Square(10000);

            //act
            var result_A = square.CalculateArea();

            //assert
            Assert.AreEqual(100000000, result_A);

            //act
            var result_P = square.CalculatePerimeter();
            Assert.AreEqual(40000, result_A);
        }

        [TestMethod]
        public void TestVerySmallSide() {

            //Arrange
            var square = new Square(0.001);
            
            //Act
            var result_A = square.CalculateArea();

            //Assert
            Assert.AreEqual(0.000001, result_A);

            //Act
            var result_P = square. CalculatePerimeter();

            //Assert
            Assert.AreEqual(0.004,result_P);
        }
    }
    /*Square Test ends here*/


    /*Rectangle Test starts here*/
    [TestClass]
    public class RectangleTests()
    {
        [TestMethod]
        public void TestArea() {
            
            //Arrange
            var rectangle = new Rectangle(10, 5);
            
            //act
            var result = rectangle.CalculateArea();

            //Assert
            Assert.AreEqual(50, result);
        }

        [TestMethod]
        public void TestPerimeter() 
        {
            //Arrange
            var rectangle = new Rectangle(10, 5);

            //Act
            var result= rectangle.CalculatePerimeter();

            //Assert
            Assert.AreEqual(30, result);
        }

        [TestMethod]
        public void TestSideIsZero()
        {
            //Arrange
            var rectangle = new Rectangle(10, 0);

            //Act
            var result_A = rectangle.CalculateArea();

            //Assert
            Assert.AreEqual(0,result_A);

            //Act
            var result_P = rectangle.CalculatePerimeter();

            //Arrange
            Assert.AreEqual(20,result_P);
        }

        [TestMethod]
        public void TestSmallDimensions() {

            //Arrange
            var rectangle = new Rectangle(0.1, 0.4);

            //Act
            var result_A = rectangle.CalculateArea();

            //Assert
            Assert.AreEqual(0.04, result_A);

            //Act
            var result_P = rectangle.CalculatePerimeter();

            //Assert
            Assert.AreEqual(0.5, result_P);
        }
    }
    /*Rectangle Test ends here*/



    /*Triangle Test starts here*/
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void TestArea() 
        {
            //Arrange
            var trianlge = new Triangle(10, 5, 8, 7);

            //Act
            var result = trianlge.CalculateArea();

            //Arrange
            Assert.AreEqual(25, result);
        }

        [TestMethod]
        public void TestPerimeter()
        {
            //Arrange
            var triangle = new Triangle(10, 5, 8, 7);

            //Act
            var result = triangle.CalculatePerimeter();

            //Assert
            Assert.AreEqual(25, result);
        }

        [TestMethod]
        public void TestDegenerateTriangle()
        {
            //Arrange
            var triangle = new Triangle(0,0,0,0);

            //Act
            var result_A = triangle.CalculatePerimeter();

            //Assert
            Assert.AreEqual(0,result_A);
            
            //Act
            var result_P = triangle.CalculatePerimeter();  

            //Assert
            Assert.AreEqual(0,result_P);
        }

        [TestMethod]
        public void TestRightTriangle()
        {
            //Arrange
            var triangle = new Triangle(3,4,5,4);
            
            //Act
            var result_A = triangle.CalculateArea();

            //Assert
            Assert.AreEqual(6,result_A);
            

            //Act
            var result_P = triangle.CalculatePerimeter(); 
            
            //Arrange
            Assert.AreEqual(12,result_P);
        }

        public void TestArea_EquilateralTriangle_ReturnsCorrectArea()
        {
            //Arrange
            var triangle = new Triangle(10, 8.66, 10, 10); // Equilateral triangle sides 10, height approx 8.66

            //Act
            var result_A = triangle.CalculateArea();

            //Assert
            Assert.AreEqual(43.3, Math.Round(result_A, 1));
        }
    }
    /*Triangle Test ends here*/
}