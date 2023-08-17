using GeometryLibrary.Entities;

namespace GeometryLibraryTests
{
    [TestFixture]
    public class ShapeTests
    {
        [Test]
        public void CircleGetArea_ReturnsCorrectValue()
        {
            Circle circle = new Circle(5);
            double expectedArea = 78.53981633974483;
            double actualArea = circle.GetArea();
            Assert.AreEqual(expectedArea, actualArea, 0.000001);
        }

        [Test]
        public void TriangleGetArea_ReturnsCorrectValue()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            double expectedArea = 6;
            double actualArea = triangle.GetArea();
            Assert.AreEqual(expectedArea, actualArea, 0.000001);
        }

        [Test]
        public void TriangleIsRightTriangle_ReturnsTrue()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            bool isRightTriangle = triangle.IsRightTriangle();
            Assert.IsTrue(isRightTriangle);
        }

        [Test]
        public void TriangleIsRightTriangle_ReturnsFalse()
        {
            Triangle triangle = new Triangle(2, 3, 4);
            bool isRightTriangle = triangle.IsRightTriangle();
            Assert.IsFalse(isRightTriangle);
        }
    }
}