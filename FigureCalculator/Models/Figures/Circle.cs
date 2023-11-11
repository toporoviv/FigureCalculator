using FigureCalculator.Exceptions;
using FigureCalculator.Helpers;
using FigureCalculator.Models.Interfaces;

namespace FigureCalculator.Models.Figures
{
    public class Circle : IFigure
    {
        public double Radius { get; private set; }

        public Circle(double radius)
        {
            if (radius < MathHelper.Eps) throw new NotExistCircleException();

            Radius = radius;
        }

        public double GetSquare()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
