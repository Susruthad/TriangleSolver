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

        //5
        [Test]
        public void ValidTriangle_Input3and4and5_OutputScalene()
        {
            // Arrange
            int side1 = 3;
            int side2 = 4;
            int side3 = 5;
            string expected = "Scalene triangle";

            // Act
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }
        //6

        [Test]
        public void ValidTriangle_Input6and8and10_OutputScalene()
        {
            // Arrange
            int side1 = 6;
            int side2 = 8;
            int side3 = 10;
            string expected = "Scalene triangle";

            // Act
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        //7

        [Test]
        public void ValidTriangle_Input7and9and11_OutputScalene()
        {
            // Arrange
            int side1 = 7;
            int side2 = 9;
            int side3 = 11;
            string expected = "Scalene triangle";

            // Act
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        //8

        [Test]
        public void ValidTriangle_Input10and12and15_OutputScalene()
        {
            // Arrange
            int side1 = 10;
            int side2 = 12;
            int side3 = 15;
            string expected = "Scalene triangle";

            // Act
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        //9

        [Test]
        public void ValidTriangle_Input12and15and17_OutputScalene()
        {
            // Arrange
            int side1 = 12;
            int side2 = 15;
            int side3 = 17;
            string expected = "Scalene triangle";

            // Act
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }




    }
}
