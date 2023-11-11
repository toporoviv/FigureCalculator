using FigureCalculator.Exceptions;
using FigureCalculator.Models.Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureCalculator.Tests
{
    public class CircleTests
    {
        [Test]
        [TestCase(5.0, Math.PI * 5.0 * 5.0)]
        [TestCase(2.75, Math.PI * 2.75 * 2.75)]
        public void GetSquare_CircleWithPositiveRadius_CorrectSquare(double radius, double square)
        {
            var circle = new Circle(radius);
            var calculateSquare = circle.GetSquare();

            Assert.That(calculateSquare, Is.EqualTo(square).Within(0.0001));
        }

        [Test]
        public void CreateCircle_InvalidRadius_ThrowNotExistCircleException()
        {
            Assert.Throws<NotExistCircleException>(() =>
            {
                var circle = new Circle(-3.7);
            });
        }
    }
}
