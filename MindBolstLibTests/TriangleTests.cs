using MindBoxTestLib.Figures;
using Xunit;

namespace MindBolstLibTests
{
    public class TriangleTests
    {
        [Theory]
        [InlineData(3, 4, 5, 6)]
        [InlineData(5, 12, 13, 30)]
        [InlineData(8, 15, 17, 60)]
        public void CalculateArea_ValidTriangle_ReturnsExpectedArea(double side1, double side2, double side3, double expectedArea)
        {
            // Arrange
            Shape triangle = new Triangle(side1, side2, side3);

            // Act
            double area = triangle.CalculateArea();

            // Assert
            Assert.Equal(expectedArea, area, precision: 2);
        }

        [Theory]
        [InlineData(0, 4, 5)]
        [InlineData(3, -1, 2)]
        [InlineData(1, 2, 10)]
        public void CalculateArea_InvalidTriangle_ThrowsArgumentException(double side1, double side2, double side3)
        {
            // Arrange
            Shape triangle = new Triangle(side1, side2, side3);

            // Assert
            Assert.Throws<ArgumentException>(() => triangle.CalculateArea());
        }

        [Theory]
        [InlineData(3, 4, 5, true)]
        [InlineData(5, 12, 13, true)]
        [InlineData(8, 15, 17, true)]
        [InlineData(1, 2, 3, false)]
        [InlineData(5, 5, 9, false)]
        public void IsRightTriangle_ValidTriangle_ReturnsExpectedResult(double side1, double side2, double side3, bool expectedResult)
        {
            // Arrange
            Triangle triangle = new Triangle(side1, side2, side3);

            // Act
            bool isRightTriangle = triangle.IsRightTriangle();

            // Assert
            Assert.Equal(expectedResult, isRightTriangle);
        }

        [Theory]
        [InlineData(0, 4, 5)]
        [InlineData(3, -1, 2)]
        [InlineData(1, 2, 10)]
        public void IsRightTriangle_InvalidTriangle_ThrowsArgumentException(double side1, double side2, double side3)
        {
            // Arrange
            Shape triangle = new Triangle(side1, side2, side3);

            // Assert
            Assert.Throws<ArgumentException>(() => triangle.CalculateArea());
        }

    }
}