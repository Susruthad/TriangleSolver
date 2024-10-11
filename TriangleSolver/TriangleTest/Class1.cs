using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TriangleSolver;
using NUnit.Framework;

namespace TriangleTest
{
    [TestFixture]
    public class TriangleTests
    {
        // 1
        [Test]
        public void ValidTriangle_Input3and3and3_OutputEquilateral()
        {
            // Arrange
            int side1 = 3;
            int side2 = 3;
            int side3 = 3;
            string expected = "Equilateral triangle";

            // Act
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }
        //2
        [Test]
        public void ValidTriangle_Input5and5and8_OutputIsosceles()
        {
            // Arrange
            int side1 = 5;
            int side2 = 5;
            int side3 = 8;
            string expected = "Isosceles triangle";

            // Act
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }
        //3
        [Test]
        public void ValidTriangle_Input6and6and10_OutputIsosceles()
        {
            // Arrange
            int side1 = 6;
            int side2 = 6;
            int side3 = 10;
            string expected = "Isosceles triangle";

            // Act
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }
        //4
        [Test]
        public void ValidTriangle_Input9and9and7_OutputIsosceles()
        {
            // Arrange
            int side1 = 9;
            int side2 = 9;
            int side3 = 7;
            string expected = "Isosceles triangle";

            // Act
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }





    }
}
