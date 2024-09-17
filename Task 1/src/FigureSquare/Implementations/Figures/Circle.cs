namespace FigureSquare.Implementations.Figures
{
    using FigureSquare.Abstractions;

    internal class Circle : Figure, ICircle
    {
        private readonly double _radius;

        /// <summary>
        /// Создать круг.
        /// </summary>
        /// <param name="radius">Радиус</param>
        public Circle(double radius)
        {
            _radius = radius;
        }

        /// <summary>
        /// Рассчитать площадь круга.
        /// </summary>
        /// <returns>Площадь круга.</returns>
        public override double CalculateSquare() => Math.PI * _radius * _radius;

        /// <summary>
        /// Получить радиус круга.
        /// </summary>
        /// <returns>Радиус.</returns>
        public double GetRadius() => _radius;

        /// <summary>
        /// Получить диаметр круга.
        /// </summary>
        /// <returns>Диаметр.</returns>
        public double GetDiameter() => 2 * _radius;

        /// <summary>
        /// Получить диаметр круга.
        /// </summary>
        /// <returns>Диаметр.</returns>
        public double GetCircleLength() => 2 * Math.PI * _radius;
    }
}
