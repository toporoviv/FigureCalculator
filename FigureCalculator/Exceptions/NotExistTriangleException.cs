using System.Runtime.Serialization;

namespace FigureCalculator.Exceptions
{
    public class NotExistTriangleException : Exception
    {
        public NotExistTriangleException() : base("Данного треугольника не существует")
        {
        }
    }
}