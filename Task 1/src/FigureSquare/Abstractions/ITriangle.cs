namespace FigureSquare.Abstractions
{
    public interface ITriangle : IFigure
    {
        /// <summary>
        /// Рассчитать периметр треугольника.
        /// </summary>
        /// <returns>Периметр.</returns>
        public double CalculatePerimeter();

        /// <summary>
        /// Рассчитать площадь треугольника.
        /// </summary>
        /// <returns>Площадь.</returns>
        public double CalculateSquare();

        /// <summary>
        /// Получить стороны треугольника. 
        /// </summary>
        /// <returns>Стороны треугольника.</returns>
        public (double, double, double) GetSides();
        
        /// <summary>
        /// Проверить, является ли треугольник правильным.
        /// </summary>
        /// <returns>True - если правильный, False - если нет.</returns>
        public bool IsRightTriangle();

        /// <summary>
        /// Проверить, является ли треугольник прямоугольным.
        /// </summary>
        /// <returns>True - если прямоугольный, False - если нет.</returns>
        public bool IsRectangleTriangle();
    }
}
