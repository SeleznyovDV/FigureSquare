namespace FigureSquare.Implementations.Figures
{
    using FigureSquare.Abstractions;

    internal class Triangle : Figure, ITriangle
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
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
            {
                throw new ArgumentException("Стороны треугольника должны быть положительными.");
            }

            if (sideA + sideB <= sideC || sideA + sideC <= sideB || sideB + sideC <= sideA)
            {
                throw new ArgumentException("Сумма двух сторон должна быть больше третьей стороны.");
            }

            _sideA = sideA;
            _sideB = sideB;
            _sideC = sideC;
        }

        /// <summary>
        /// Рассчитать периметр треугольника.
        /// </summary>
        /// <returns>Периметр.</returns>
        public double CalculatePerimeter() => _sideA + _sideB + _sideC;

        /// <summary>
        /// Рассчитать площадь треугольника. 
        /// </summary>
        /// <returns></returns>
        public override double CalculateSquare()
        {
            double s = (_sideA + _sideB + _sideC) / 2;
            return Math.Sqrt(s * (s - _sideA) * (s - _sideB) * (s - _sideC));
        }

        /// <summary>
        /// Получить стороны треугольника. 
        /// </summary>
        /// <returns>Стороны треугольника.</returns>
        public (double, double, double) GetSides() => new(_sideA, _sideB, _sideC);


        /// <summary>
        /// Проверить, является ли треугольник прямоугольным.
        /// </summary>
        /// <returns>True - если прямоугольный, False - если нет.</returns>
        public bool IsRectangleTriangle()
        {
            double[] sides = { _sideA, _sideB, _sideC };
            Array.Sort(sides);
            return Math.Abs(sides[0] * sides[0] + sides[1] * sides[1] - sides[2] * sides[2]) < 1e-10;
        }

        /// <summary>
        /// Проверить, является ли треугольник правильным.
        /// </summary>
        /// <returns>True - если правильный, False - если нет.</returns>
        public bool IsRightTriangle() => _sideA == _sideB && _sideB == _sideC;
    }
}
