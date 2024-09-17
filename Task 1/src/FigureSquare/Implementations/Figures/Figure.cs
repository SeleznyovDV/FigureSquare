namespace FigureSquare.Implementations.Figures
{
    using FigureSquare.Abstractions;
    internal abstract class Figure : IFigure
    {
        /// <summary>
        /// Рассчитать площадь фигуры.
        /// </summary>
        /// <returns>Площадь фигуры.</returns>
        public abstract double CalculateSquare();
    }
}
