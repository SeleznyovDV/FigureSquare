namespace FigureSquare.Abstractions
{
    public interface ICircle : IFigure
    {
        /// <summary>
        /// Рассчитать площадь круга.
        /// </summary>
        /// <returns>Площадь круга.</returns>
        public double CalculateSquare();

        /// <summary>
        /// Получить радиус круга.
        /// </summary>
        /// <returns>Радиус.</returns>
        public double GetRadius();

        /// <summary>
        /// Получить диаметр круга.
        /// </summary>
        /// <returns>Диаметр.</returns>
        public double GetDiameter();

        /// <summary>
        /// Получить диаметр круга.
        /// </summary>
        /// <returns>Диаметр.</returns>
        public double GetCircleLength();
    }
}
