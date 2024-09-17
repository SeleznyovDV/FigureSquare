namespace FigureSquare.Abstractions
{
    public interface ITriangle
    {
        /// <summary>
        /// Рассчитать периметр треугольника.
        /// </summary>
        /// <returns>Периметр.</returns>
        public double CalculatePerimeter();
        
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
        /// Проверить, является ли треугольник правильным.
        /// </summary>
        /// <returns>True - если правильный, False - если нет.</returns>
        public bool IsRectangleTriangle();
    }
}
