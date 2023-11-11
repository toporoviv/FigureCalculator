using System.Runtime.Serialization;

namespace FigureCalculator.Exceptions
{
    public class NotExistCircleException : Exception
    {
        public NotExistCircleException() : base("Данной окружности не существует") 
        {
        }
    }
}