namespace FigureSquare.Implementations
{
    using FigureSquare.Abstractions;
    public class Triangle : Figure
    {
        private readonly double _sideA;
        private readonly double _sideB;
        private readonly double _sideC;
        
        /// <summary>
        /// Создать треугольник.
        /// </summary>
        /// <param name="sideA">Сторона A.</param>
        /// <param name="sideB">Сторона B.</param>
        /// <param name="sideC">Сторона C.</param>
        public Triangle(double sideA, double sideB, double sideC)
        {
            _sideA = sideA;
            _sideB = sideB;
            _sideC = sideC;
        }
        
        /// <summary>
        /// Рассчитать площадь треугольника. 
        /// </summary>
        /// <returns></returns>
        public override double CalculateSquare()
        {
            double s = (_sideA + _sideB + _sideC) / 2;
            return Math.Sqrt(s * (s - _sideA) * (s - _sideB) * (s - _sideC));
        }
    }
}
