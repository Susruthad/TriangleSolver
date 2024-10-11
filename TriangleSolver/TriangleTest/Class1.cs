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
        



    }
}
