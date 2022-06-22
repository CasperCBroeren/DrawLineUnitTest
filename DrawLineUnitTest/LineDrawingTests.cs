using System;
using System.Drawing;
using Xunit;

namespace DrawLineUnitTest
{
    public class LineDrawingTests
    {
        [Fact]
        public void Project_AtoB_Map()
        {
            // Arrange 
            var a = new Coordinate2d(1, 1);
            var b = new Coordinate2d(100, 100);
            var line = new Line(Color.Black, a, b, 1);

            // Act 
            var result = line.Project(100m);
            var resultHalfWay = line.Project(50m);

            // Assert
            Assert.Equal(100m, result.Y);
            Assert.Equal(50m, resultHalfWay.Y);
        }

        [Theory]
        [InlineData(1,100)]
        [InlineData(100, 1)]
        [InlineData(100, 100)]
        [InlineData(50, 50)]
        [InlineData(50, 25)]
        public void DrawLine_BlackHorizontal_Black(decimal endX, decimal endY)
        {
            // Arrange
            var a = new Coordinate2d(1, 1);

            var b = new Coordinate2d(endX, endY);
            var color = Color.Black;
            var canvas = new Canvas2d(new Coordinate2d(0, 0), new Coordinate2d(100, 100));

            // Act
            canvas.DrawLine(color, a, b, 1);

            // Assert
            var middle = (a + b) / 2m;
            Assert.Equal(canvas.SampleColor(a), color);
            Assert.Equal(canvas.SampleColor(middle), color);
            Assert.Equal(canvas.SampleColor(b), color);
        }

      
    }
}
