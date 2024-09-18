namespace FigureSquare.Implementations.Figures
{
    using FigureSquare.Abstractions;
    public abstract class Figure : IFigure
    {
        /// <summary>
        /// Рассчитать площадь фигуры.
        /// </summary>
        /// <returns>Площадь фигуры.</returns>
        public abstract double CalculateSquare();
    }
}
