using FigureCalculator.Exceptions;
using FigureCalculator.Helpers;
using FigureCalculator.Models.Interfaces;

namespace FigureCalculator.Models.Figures
{
    public class Triangle : IFigure
    {
        public double FirstSide { get; private set; }

        public double SecondSide { get; private set; }

        public double ThirdSide { get; private set; }

        public Triangle(double firstSide, double secondSide, double thirdSide)
        {
            if (firstSide < MathHelper.Eps
                || secondSide < MathHelper.Eps
                || thirdSide < MathHelper.Eps) throw new NotExistTriangleException();

            if (firstSide + secondSide < thirdSide
                || firstSide + thirdSide < secondSide
                || secondSide + thirdSide < firstSide) throw new NotExistTriangleException();

            FirstSide = firstSide;
            SecondSide = secondSide;
            ThirdSide = thirdSide;
        }

        public bool IsRightTriangle() =>
            (Math.Abs(FirstSide * FirstSide - SecondSide * SecondSide - ThirdSide * ThirdSide) < MathHelper.Eps)
                || (Math.Abs(SecondSide * SecondSide - FirstSide * FirstSide - ThirdSide * ThirdSide) < MathHelper.Eps)
                || (Math.Abs(SecondSide * SecondSide + FirstSide * FirstSide - ThirdSide * ThirdSide) < MathHelper.Eps);

        public double GetSquare()
        {
            var halfMeter = (FirstSide + SecondSide + ThirdSide) / 2;
            return Math.Sqrt(halfMeter * (halfMeter - FirstSide) * (halfMeter - SecondSide) * (halfMeter - ThirdSide));
        }
    }
}
