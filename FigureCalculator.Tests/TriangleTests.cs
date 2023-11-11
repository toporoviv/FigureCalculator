using FigureCalculator.Exceptions;
using FigureCalculator.Models.Figures;

namespace FigureCalculator.Tests
{
    [TestFixture]
    public class TriangleTests
    {
        [Test]
        [TestCase(2, 2, 3, 1.9843)]
        [TestCase(3, 4, 5, 6)]
        public void GetSquare_TriangleWithValidSides_CorrectSquare(
            double firstSide, double secondSize, double thirdSize, double square)
        {
            var triangle = new Triangle(firstSide, secondSize, thirdSize);
            var calculateSquare = triangle.GetSquare();

            Assert.That(calculateSquare, Is.EqualTo(square).Within(0.0001));
        }

        [Test]
        public void IsRightTriangle_RightTriangleWithValidSides_True()
        {
            var triangle = new Triangle(3, 4, 5);
            var isRightTriangle = triangle.IsRightTriangle();

            Assert.That(isRightTriangle, Is.EqualTo(true));
        }

        [Test]
        [TestCase(3, 4, -1)]
        [TestCase(1, 2, 3.25)]
        public void CreateTriangle_InvalidSides_ThrowNotExistTriangleException(
            double firstSide, double secondSide, double thirdSide)
        {
            Assert.Throws<NotExistTriangleException>(() =>
            {
                var triangle = new Triangle(firstSide, secondSide, thirdSide);
            });
        }
    }
}
