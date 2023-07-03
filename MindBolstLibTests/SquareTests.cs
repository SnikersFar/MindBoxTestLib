using Microsoft.VisualStudio.TestPlatform.TestHost;
using MindBoxTestLib;
using MindBoxTestLib.Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace MindBolstLibTests
{
    public class SquareTests
    {
        [Theory]
        [InlineData(2)]
        [InlineData(4)]
        [InlineData(6)]
        public void CalculateArea_ReturnsCorrectArea(double radius)
        {
            // Arrange
            Shape circle = new Circle(radius);

            // Act
            double area = circle.CalculateArea();

            // Assert
            double expectedArea = Math.PI * radius * radius;
            Assert.Equal(expectedArea, area);
        }

        [Fact]
        public void CalculateArea_ReturnsZeroForZeroRadius()
        {
            // Arrange
            double radius = 0;
            Shape circle = new Circle(radius);

            // Act
            double area = circle.CalculateArea();

            // Assert
            Assert.Equal(0, area);
        }

        [Fact]
        public void CalculateArea_ReturnsPositiveAreaForNegativeRadius()
        {            
            // Arrange
            double radius = -5;
            Shape circle = new Circle(radius);

            // Act
            double area = circle.CalculateArea();

            // Assert
            Assert.True(area > 0);
        }
    }
}
